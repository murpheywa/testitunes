using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTunesLib;
using System.Diagnostics;
using TestITunes.Properties;
using System.IO;


namespace TestITunes
{
	public partial class Form1 : Form
	{
		delegate void Router(object arg);
		iTunesApp _app = null;
		Dictionary<string, UInt64> _playListtDict = null;
		bool _bCancel = false;
		private string _sPlayListName;
		IITUserPlaylist _playList = null;
		IITFileOrCDTrack _track = null;
		string _sTargetDir = "";
		private bool _bRefreshed = false;
		string _sPlayListTargetPath = "";
		string _sTrackTargetPath = "";
		string _sSrcPath = "";

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			_playListtDict = new Dictionary<string, UInt64>(StringComparer.OrdinalIgnoreCase);
			GetSettings();
			tbDst.SelectionStart = 0;
			tbDst.ScrollToCaret();
			tslPlaylist.Text = ""; tslTrack.Text = "";
			tslState.Text = "Stopped";
			_app = new iTunesApp();
		}

		void Alert(string sText)
		{
			MessageBox.Show(sText);
		}

		private void GetSettings()
		{
			tbDst.Text = Settings.Default.Dst;
			txtTarget.Text = Settings.Default.TargetDir;

			bool bChecked = false;
			Boolean.TryParse(Settings.Default.Overwrite, out bChecked);
			chkOverwrite.Checked = bChecked;
        }

		private void SaveSettings()
		{
			Settings.Default.Dst = tbDst.Text;
			Settings.Default.TargetDir = txtTarget.Text;
			Settings.Default.Overwrite = chkOverwrite.Checked.ToString();
			Settings.Default.Save();
		}
		string NameToFileName(string sName, string sExtraInvalidChars)
		{
			string sInvalids = new string(Path.GetInvalidFileNameChars()) + sExtraInvalidChars;
			StringBuilder bldrPath = new StringBuilder();
			foreach( char iterCh in sName)
			{
				if (sInvalids.IndexOf(iterCh) >= 0 )
				{
					bldrPath.Append('_');
				}
				else
				{
					bldrPath.Append(iterCh);
				}
			}

			return bldrPath.ToString();
		}

		string NameToFileName(string sName)
		{
			return NameToFileName(sName, "");
		}

		private string TrackNameToPath(string name)
		{
			throw new NotImplementedException();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_app != null)
			{
				_app = null;
			}
			SaveSettings();
		}

		private void cmdRefresh_Click(object sender, EventArgs e)
		{
			if (_app == null)
			{
				_app = new iTunesApp();
			}
			tslPlaylist.Text = ""; tslTrack.Text = "";
			string sVersion = _app.Version;
			string sPath = _app.LibraryXMLPath;

			tbSrc.Clear();
			var oSource = _app.LibrarySource;
            foreach (IITPlaylist pl in oSource.Playlists)
			{
				ITPlaylistKind eKind = pl.Kind;
				IITUserPlaylist plUser = null;
				bool bSmart = false;
				ITUserPlaylistSpecialKind eSpecialKind = ITUserPlaylistSpecialKind.ITUserPlaylistSpecialKindNone;
				IITUserPlaylist u2 = null;
				if ( eKind == ITPlaylistKind.ITPlaylistKindUser)
				{
					plUser = pl as IITUserPlaylist;
					bSmart = plUser.Smart;
					eSpecialKind = plUser.SpecialKind;
					if ( bSmart == false && eSpecialKind == ITUserPlaylistSpecialKind.ITUserPlaylistSpecialKindNone)
					{
						UInt64 uIndex = (UInt64)(((long)plUser.sourceID) << 32 | (long)plUser.playlistID);
						_playListtDict.Add(plUser.Name, uIndex);
						// confirm
						u2 = GetPlayList(plUser.Name);

                    }
				}
				tbSrc.SelectionStart = 0;
				tbSrc.ScrollToCaret();

				_bRefreshed = true;
			}

			foreach (KeyValuePair<string,UInt64> iterPair in _playListtDict.OrderBy(x => x.Key.ToLower()))
            {
				tbSrc.AppendText(iterPair.Key + Environment.NewLine);
			}

		}

		private IITUserPlaylist GetPlayList(string name)
		{
			IITUserPlaylist pl = null;
			UInt64 uiSourcePlaylist = 0;
			if (_playListtDict.TryGetValue(name, out uiSourcePlaylist))
			{
				int uiSource = (int)(uiSourcePlaylist >> 32);
				int uiPlaylist = (int)(uiSourcePlaylist & 0x00000000ffffffff);
				IITObject o = null;
				try
				{
					o = _app.GetITObjectByID(uiSource, uiPlaylist, 0, 0);
				}
				catch (Exception)
				{
				}
				pl = o as IITUserPlaylist;
			}

			return pl;
		}

		private void cmdExport_Click(object sender, EventArgs e)
		{
			SaveSettings();
			txtLog.Clear();

			if (string.IsNullOrWhiteSpace(txtTarget.Text))
			{
				Alert("No target directory selected");
			}
			else if (string.IsNullOrWhiteSpace(tbDst.Text))
			{
				Alert("No playlists selected");
			}
			else if (! _bRefreshed)
			{
				Alert("Playlists need to be refreshed");
			}
			else
			{
				try
				{
					tslPlaylist.Text = ""; tslTrack.Text = "";
					_sTargetDir = txtTarget.Text;
					Directory.CreateDirectory(_sTargetDir);
					_bCancel = false;
					tslState.Text = "Running";
					DoExport();
					tslState.Text = 
						_bCancel
						? "Stopped"
						: "Done";
					_bCancel = false;
				}
				catch (Exception ex)
				{
					Alert(ex.Message);
				}
			}
		}

		private void DoExport()
		{
			tslPlaylist.Text = "";
			foreach (string sIterPlayList in tbDst.Text.Replace("\r","").Split('\n'))
			{
				if (! string.IsNullOrWhiteSpace(sIterPlayList))
				{
					_sPlayListName = sIterPlayList;
					_sPlayListTargetPath = Path.Combine(_sTargetDir, NameToFileName(_sPlayListName));
					_playList = GetPlayList(_sPlayListName);
					if ( _playList == null)
					{
						Alert("Cannot find playlist " + _sPlayListName);
						_bCancel = true;
						break;
					}

					Directory.CreateDirectory(_sPlayListTargetPath);
					tslPlaylist.Text = _sPlayListName;
					DoExportPlaylist();
					if ( _bCancel)
					{
						break;
					}
				}
			}
		}

		private void DoExportPlaylist()
		{
			foreach( IITTrack iterTrack in _playList.Tracks)
			{
				_track = iterTrack as IITFileOrCDTrack;
				tslTrack.Text = _track.Name;
				Application.DoEvents();
				if ( _bCancel )
				{
					break;
				}

				_sSrcPath = _track.Location;
				ITTrackKind kind = _track.Kind;
				string sKind = _track.KindAsString;
				string sTargetName = NameToFileName(_track.Name, " ");
				// to fix version 1 bug
				_sTrackTargetPath = Path.Combine(_sPlayListTargetPath, sTargetName);
				if (File.Exists(_sTrackTargetPath))
				{
					File.Delete(_sTrackTargetPath);
				}
				string sSrcExt = Path.GetExtension(_sSrcPath);
				_sTrackTargetPath = Path.Combine(_sPlayListTargetPath, sTargetName + sSrcExt);
				bool bExists = File.Exists(_sTrackTargetPath);
				if ((!bExists) || chkOverwrite.Checked)
				{
					if (sKind.IndexOf("protected", StringComparison.Ordinal) >= 0)
					{
						string sMsg = String.Format("{0} {1} is copy protected",
							_sPlayListName, _track.Name);
						Log(sMsg);
					}
					else
					{
						try
						{
							File.Copy(_sSrcPath, _sTrackTargetPath, true);
						}
						catch (Exception ex)
						{
							Alert(ex.Message);
							_bCancel = true;
							break;
						}
					}
				}
            }
		}

		private void Log(string sText)
		{
			txtLog.AppendText(sText + Environment.NewLine);
		}

		private void cmdcancel_Click(object sender, EventArgs e)
		{
			_bCancel = true;
		}
	}
}
