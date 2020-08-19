namespace ClosedCaptionHelper
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openVideoAudioFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.newClosedCaptionsFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openClosedCaptionsFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveClosedCaptionsFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveClosedCaptionsFileAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exportTranscriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startaddCaptionStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoSecondsBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoSecondsForwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCurrentCaptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captionsList = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startEdt = new System.Windows.Forms.TextBox();
            this.endEdt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.captionEdt = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.voiceLbl = new System.Windows.Forms.Label();
            this.splitBtn = new System.Windows.Forms.Button();
            this.MergeBtn = new System.Windows.Forms.Button();
            this.mergePrevBtb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(471, 27);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(481, 349);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.axWindowsMediaPlayer1.PositionChange += new AxWMPLib._WMPOCXEvents_PositionChangeEventHandler(this.axWindowsMediaPlayer1_PositionChange);
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(958, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openVideoAudioFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.newClosedCaptionsFileToolStripMenuItem,
            this.openClosedCaptionsFileToolStripMenuItem,
            this.saveClosedCaptionsFileToolStripMenuItem,
            this.saveClosedCaptionsFileAsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exportTranscriptToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openVideoAudioFileToolStripMenuItem
            // 
            this.openVideoAudioFileToolStripMenuItem.Name = "openVideoAudioFileToolStripMenuItem";
            this.openVideoAudioFileToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.openVideoAudioFileToolStripMenuItem.Text = "Open Video/Audio file";
            this.openVideoAudioFileToolStripMenuItem.Click += new System.EventHandler(this.openVideoAudioFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(233, 6);
            // 
            // newClosedCaptionsFileToolStripMenuItem
            // 
            this.newClosedCaptionsFileToolStripMenuItem.Name = "newClosedCaptionsFileToolStripMenuItem";
            this.newClosedCaptionsFileToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.newClosedCaptionsFileToolStripMenuItem.Text = "&New Closed Captions File";
            this.newClosedCaptionsFileToolStripMenuItem.Click += new System.EventHandler(this.newClosedCaptionsFileToolStripMenuItem_Click);
            // 
            // openClosedCaptionsFileToolStripMenuItem
            // 
            this.openClosedCaptionsFileToolStripMenuItem.Name = "openClosedCaptionsFileToolStripMenuItem";
            this.openClosedCaptionsFileToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.openClosedCaptionsFileToolStripMenuItem.Text = "Open Closed Captions File ...";
            this.openClosedCaptionsFileToolStripMenuItem.Click += new System.EventHandler(this.openClosedCaptionsFileToolStripMenuItem_Click);
            // 
            // saveClosedCaptionsFileToolStripMenuItem
            // 
            this.saveClosedCaptionsFileToolStripMenuItem.Name = "saveClosedCaptionsFileToolStripMenuItem";
            this.saveClosedCaptionsFileToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.saveClosedCaptionsFileToolStripMenuItem.Text = "&Save Closed Captions File";
            this.saveClosedCaptionsFileToolStripMenuItem.Click += new System.EventHandler(this.saveClosedCaptionsFileToolStripMenuItem_Click);
            // 
            // saveClosedCaptionsFileAsToolStripMenuItem
            // 
            this.saveClosedCaptionsFileAsToolStripMenuItem.Name = "saveClosedCaptionsFileAsToolStripMenuItem";
            this.saveClosedCaptionsFileAsToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.saveClosedCaptionsFileAsToolStripMenuItem.Text = "Save Closed Captions File As ...";
            this.saveClosedCaptionsFileAsToolStripMenuItem.Click += new System.EventHandler(this.saveClosedCaptionsFileAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(233, 6);
            // 
            // exportTranscriptToolStripMenuItem
            // 
            this.exportTranscriptToolStripMenuItem.Name = "exportTranscriptToolStripMenuItem";
            this.exportTranscriptToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.exportTranscriptToolStripMenuItem.Text = "&Export transcript";
            this.exportTranscriptToolStripMenuItem.Click += new System.EventHandler(this.exportTranscriptToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startaddCaptionStopToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.twoSecondsBackToolStripMenuItem,
            this.twoSecondsForwardToolStripMenuItem,
            this.backToStartToolStripMenuItem,
            this.deleteCurrentCaptionToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Del";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // startaddCaptionStopToolStripMenuItem
            // 
            this.startaddCaptionStopToolStripMenuItem.Name = "startaddCaptionStopToolStripMenuItem";
            this.startaddCaptionStopToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.startaddCaptionStopToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.startaddCaptionStopToolStripMenuItem.Text = "Start (add caption)/Stop";
            this.startaddCaptionStopToolStripMenuItem.Click += new System.EventHandler(this.startaddCaptionStopToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+R";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.restartToolStripMenuItem.Text = "Restart current caption";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // twoSecondsBackToolStripMenuItem
            // 
            this.twoSecondsBackToolStripMenuItem.Name = "twoSecondsBackToolStripMenuItem";
            this.twoSecondsBackToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Left";
            this.twoSecondsBackToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.twoSecondsBackToolStripMenuItem.Text = "Two seconds back";
            this.twoSecondsBackToolStripMenuItem.Click += new System.EventHandler(this.twoSecondsBackToolStripMenuItem_Click);
            // 
            // twoSecondsForwardToolStripMenuItem
            // 
            this.twoSecondsForwardToolStripMenuItem.Name = "twoSecondsForwardToolStripMenuItem";
            this.twoSecondsForwardToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Right";
            this.twoSecondsForwardToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.twoSecondsForwardToolStripMenuItem.Text = "Two seconds forward";
            this.twoSecondsForwardToolStripMenuItem.Click += new System.EventHandler(this.twoSecondsForwardToolStripMenuItem_Click);
            // 
            // backToStartToolStripMenuItem
            // 
            this.backToStartToolStripMenuItem.Name = "backToStartToolStripMenuItem";
            this.backToStartToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Home";
            this.backToStartToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.backToStartToolStripMenuItem.Text = "Back to start";
            this.backToStartToolStripMenuItem.Click += new System.EventHandler(this.backToStartToolStripMenuItem_Click);
            // 
            // deleteCurrentCaptionToolStripMenuItem
            // 
            this.deleteCurrentCaptionToolStripMenuItem.Name = "deleteCurrentCaptionToolStripMenuItem";
            this.deleteCurrentCaptionToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Del";
            this.deleteCurrentCaptionToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.deleteCurrentCaptionToolStripMenuItem.Text = "Delete current caption";
            this.deleteCurrentCaptionToolStripMenuItem.Click += new System.EventHandler(this.deleteCurrentCaptionToolStripMenuItem_Click);
            // 
            // captionsList
            // 
            this.captionsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.captionsList.FormattingEnabled = true;
            this.captionsList.Location = new System.Drawing.Point(5, 26);
            this.captionsList.Name = "captionsList";
            this.captionsList.Size = new System.Drawing.Size(460, 563);
            this.captionsList.TabIndex = 5;
            this.captionsList.SelectedIndexChanged += new System.EventHandler(this.captionsList_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startEdt
            // 
            this.startEdt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startEdt.Location = new System.Drawing.Point(471, 382);
            this.startEdt.Name = "startEdt";
            this.startEdt.Size = new System.Drawing.Size(137, 20);
            this.startEdt.TabIndex = 6;
            // 
            // endEdt
            // 
            this.endEdt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endEdt.Location = new System.Drawing.Point(640, 382);
            this.endEdt.Name = "endEdt";
            this.endEdt.Size = new System.Drawing.Size(137, 20);
            this.endEdt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "-->";
            // 
            // captionEdt
            // 
            this.captionEdt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.captionEdt.Location = new System.Drawing.Point(472, 409);
            this.captionEdt.Multiline = true;
            this.captionEdt.Name = "captionEdt";
            this.captionEdt.Size = new System.Drawing.Size(474, 153);
            this.captionEdt.TabIndex = 9;
            this.captionEdt.TextChanged += new System.EventHandler(this.captionEdt_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(825, 380);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // voiceLbl
            // 
            this.voiceLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.voiceLbl.AutoSize = true;
            this.voiceLbl.Location = new System.Drawing.Point(784, 384);
            this.voiceLbl.Name = "voiceLbl";
            this.voiceLbl.Size = new System.Drawing.Size(34, 13);
            this.voiceLbl.TabIndex = 11;
            this.voiceLbl.Text = "Voice";
            // 
            // splitBtn
            // 
            this.splitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.splitBtn.Enabled = false;
            this.splitBtn.Location = new System.Drawing.Point(472, 568);
            this.splitBtn.Name = "splitBtn";
            this.splitBtn.Size = new System.Drawing.Size(75, 23);
            this.splitBtn.TabIndex = 12;
            this.splitBtn.Text = "Split";
            this.splitBtn.UseVisualStyleBackColor = true;
            this.splitBtn.Click += new System.EventHandler(this.splitBtn_Click);
            // 
            // MergeBtn
            // 
            this.MergeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MergeBtn.Enabled = false;
            this.MergeBtn.Location = new System.Drawing.Point(657, 568);
            this.MergeBtn.Name = "MergeBtn";
            this.MergeBtn.Size = new System.Drawing.Size(75, 23);
            this.MergeBtn.TabIndex = 13;
            this.MergeBtn.Text = "Merge ->";
            this.MergeBtn.UseVisualStyleBackColor = true;
            // 
            // mergePrevBtb
            // 
            this.mergePrevBtb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mergePrevBtb.Location = new System.Drawing.Point(553, 568);
            this.mergePrevBtb.Name = "mergePrevBtb";
            this.mergePrevBtb.Size = new System.Drawing.Size(98, 23);
            this.mergePrevBtb.TabIndex = 14;
            this.mergePrevBtb.Text = "<- Merge (Ctrl-M)";
            this.mergePrevBtb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 600);
            this.Controls.Add(this.mergePrevBtb);
            this.Controls.Add(this.MergeBtn);
            this.Controls.Add(this.splitBtn);
            this.Controls.Add(this.voiceLbl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.captionEdt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endEdt);
            this.Controls.Add(this.startEdt);
            this.Controls.Add(this.captionsList);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Closed Caption Helper";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openVideoAudioFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newClosedCaptionsFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openClosedCaptionsFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ListBox captionsList;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox startEdt;
        private System.Windows.Forms.TextBox endEdt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox captionEdt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label voiceLbl;
        private System.Windows.Forms.Button splitBtn;
        private System.Windows.Forms.Button MergeBtn;
        private System.Windows.Forms.ToolStripMenuItem saveClosedCaptionsFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveClosedCaptionsFileAsToolStripMenuItem;
        private System.Windows.Forms.Button mergePrevBtb;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startaddCaptionStopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twoSecondsBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twoSecondsForwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exportTranscriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCurrentCaptionToolStripMenuItem;
    }
}

