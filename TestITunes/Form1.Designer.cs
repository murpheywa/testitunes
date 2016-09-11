namespace TestITunes
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cmdRefresh = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tbSrc = new System.Windows.Forms.RichTextBox();
			this.tbDst = new System.Windows.Forms.RichTextBox();
			this.cmdExport = new System.Windows.Forms.Button();
			this.ssStatue = new System.Windows.Forms.StatusStrip();
			this.tslPlaylist = new System.Windows.Forms.ToolStripStatusLabel();
			this.tslTrack = new System.Windows.Forms.ToolStripStatusLabel();
			this.tslState = new System.Windows.Forms.ToolStripStatusLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTarget = new System.Windows.Forms.TextBox();
			this.cmdcancel = new System.Windows.Forms.Button();
			this.chkOverwrite = new System.Windows.Forms.CheckBox();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.txtLog = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.ssStatue.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdRefresh
			// 
			this.cmdRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdRefresh.Location = new System.Drawing.Point(681, 12);
			this.cmdRefresh.Name = "cmdRefresh";
			this.cmdRefresh.Size = new System.Drawing.Size(83, 36);
			this.cmdRefresh.TabIndex = 0;
			this.cmdRefresh.Text = "Refresh";
			this.cmdRefresh.UseVisualStyleBackColor = true;
			this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tbSrc);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tbDst);
			this.splitContainer1.Size = new System.Drawing.Size(663, 328);
			this.splitContainer1.SplitterDistance = 340;
			this.splitContainer1.TabIndex = 1;
			// 
			// tbSrc
			// 
			this.tbSrc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbSrc.Location = new System.Drawing.Point(0, 0);
			this.tbSrc.Name = "tbSrc";
			this.tbSrc.ReadOnly = true;
			this.tbSrc.Size = new System.Drawing.Size(340, 328);
			this.tbSrc.TabIndex = 0;
			this.tbSrc.Text = "";
			// 
			// tbDst
			// 
			this.tbDst.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbDst.Location = new System.Drawing.Point(0, 0);
			this.tbDst.Name = "tbDst";
			this.tbDst.Size = new System.Drawing.Size(319, 328);
			this.tbDst.TabIndex = 0;
			this.tbDst.Text = "";
			// 
			// cmdExport
			// 
			this.cmdExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdExport.Location = new System.Drawing.Point(681, 63);
			this.cmdExport.Name = "cmdExport";
			this.cmdExport.Size = new System.Drawing.Size(83, 36);
			this.cmdExport.TabIndex = 1;
			this.cmdExport.Text = "Export";
			this.cmdExport.UseVisualStyleBackColor = true;
			this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
			// 
			// ssStatue
			// 
			this.ssStatue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslPlaylist,
            this.tslTrack,
            this.tslState});
			this.ssStatue.Location = new System.Drawing.Point(0, 438);
			this.ssStatue.Name = "ssStatue";
			this.ssStatue.Size = new System.Drawing.Size(776, 22);
			this.ssStatue.TabIndex = 2;
			this.ssStatue.Text = "statusStrip1";
			// 
			// tslPlaylist
			// 
			this.tslPlaylist.AutoSize = false;
			this.tslPlaylist.Name = "tslPlaylist";
			this.tslPlaylist.Size = new System.Drawing.Size(350, 17);
			// 
			// tslTrack
			// 
			this.tslTrack.Name = "tslTrack";
			this.tslTrack.Size = new System.Drawing.Size(360, 17);
			this.tslTrack.Spring = true;
			// 
			// tslState
			// 
			this.tslState.Name = "tslState";
			this.tslState.Size = new System.Drawing.Size(51, 17);
			this.tslState.Text = "Stopped";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Target Directory";
			// 
			// txtTarget
			// 
			this.txtTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTarget.Location = new System.Drawing.Point(101, 6);
			this.txtTarget.Name = "txtTarget";
			this.txtTarget.Size = new System.Drawing.Size(574, 20);
			this.txtTarget.TabIndex = 4;
			// 
			// cmdcancel
			// 
			this.cmdcancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdcancel.Location = new System.Drawing.Point(681, 118);
			this.cmdcancel.Name = "cmdcancel";
			this.cmdcancel.Size = new System.Drawing.Size(83, 36);
			this.cmdcancel.TabIndex = 5;
			this.cmdcancel.Text = "Cancel";
			this.cmdcancel.UseVisualStyleBackColor = true;
			this.cmdcancel.Click += new System.EventHandler(this.cmdcancel_Click);
			// 
			// chkOverwrite
			// 
			this.chkOverwrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkOverwrite.AutoSize = true;
			this.chkOverwrite.Location = new System.Drawing.Point(693, 181);
			this.chkOverwrite.Name = "chkOverwrite";
			this.chkOverwrite.Size = new System.Drawing.Size(71, 17);
			this.chkOverwrite.TabIndex = 6;
			this.chkOverwrite.Text = "Overwrite";
			this.chkOverwrite.UseVisualStyleBackColor = true;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer2.Location = new System.Drawing.Point(12, 32);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.txtLog);
			this.splitContainer2.Size = new System.Drawing.Size(663, 403);
			this.splitContainer2.SplitterDistance = 328;
			this.splitContainer2.TabIndex = 7;
			// 
			// txtLog
			// 
			this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtLog.Location = new System.Drawing.Point(0, 0);
			this.txtLog.Name = "txtLog";
			this.txtLog.Size = new System.Drawing.Size(663, 71);
			this.txtLog.TabIndex = 1;
			this.txtLog.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(776, 460);
			this.Controls.Add(this.splitContainer2);
			this.Controls.Add(this.chkOverwrite);
			this.Controls.Add(this.cmdcancel);
			this.Controls.Add(this.txtTarget);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ssStatue);
			this.Controls.Add(this.cmdExport);
			this.Controls.Add(this.cmdRefresh);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ssStatue.ResumeLayout(false);
			this.ssStatue.PerformLayout();
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdRefresh;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.RichTextBox tbSrc;
		private System.Windows.Forms.RichTextBox tbDst;
		private System.Windows.Forms.Button cmdExport;
		private System.Windows.Forms.StatusStrip ssStatue;
		private System.Windows.Forms.ToolStripStatusLabel tslPlaylist;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTarget;
		private System.Windows.Forms.Button cmdcancel;
		private System.Windows.Forms.ToolStripStatusLabel tslTrack;
		private System.Windows.Forms.CheckBox chkOverwrite;
		private System.Windows.Forms.ToolStripStatusLabel tslState;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.RichTextBox txtLog;
	}
}

