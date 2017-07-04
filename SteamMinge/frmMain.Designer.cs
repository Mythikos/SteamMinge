namespace SteamMinge
{
    partial class frmMain
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
            this.tmrInit = new System.Windows.Forms.Timer(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.tabMingeTools = new System.Windows.Forms.TabControl();
            this.pageChatBomb = new System.Windows.Forms.TabPage();
            this.lblMingeCounterCB = new System.Windows.Forms.Label();
            this.cmbThreadCountCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSteamID64CB = new System.Windows.Forms.TextBox();
            this.txtMessagesCB = new System.Windows.Forms.TextBox();
            this.btnStopCB = new System.Windows.Forms.Button();
            this.btnStartCB = new System.Windows.Forms.Button();
            this.txtIntervalCB = new System.Windows.Forms.TextBox();
            this.pageInviteSpam = new System.Windows.Forms.TabPage();
            this.lblMingeCounterIS = new System.Windows.Forms.Label();
            this.cmbThreadCountIS = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIntervalIS = new System.Windows.Forms.TextBox();
            this.txtSteamID64IS = new System.Windows.Forms.TextBox();
            this.btnStopIS = new System.Windows.Forms.Button();
            this.btnStartIS = new System.Windows.Forms.Button();
            this.tmrLoop = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.friendsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTitle = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.tabMingeTools.SuspendLayout();
            this.pageChatBomb.SuspendLayout();
            this.pageInviteSpam.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrInit
            // 
            this.tmrInit.Enabled = true;
            this.tmrInit.Interval = 1000;
            this.tmrInit.Tick += new System.EventHandler(this.tmrInit_Tick);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.DarkCyan;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(64, 0);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(232, 64);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Steam Not Detected";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.DarkCyan;
            this.picAvatar.Dock = System.Windows.Forms.DockStyle.Left;
            this.picAvatar.Location = new System.Drawing.Point(0, 0);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Padding = new System.Windows.Forms.Padding(5);
            this.picAvatar.Size = new System.Drawing.Size(64, 64);
            this.picAvatar.TabIndex = 17;
            this.picAvatar.TabStop = false;
            // 
            // tabMingeTools
            // 
            this.tabMingeTools.Controls.Add(this.pageChatBomb);
            this.tabMingeTools.Controls.Add(this.pageInviteSpam);
            this.tabMingeTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMingeTools.Location = new System.Drawing.Point(0, 88);
            this.tabMingeTools.Name = "tabMingeTools";
            this.tabMingeTools.SelectedIndex = 0;
            this.tabMingeTools.Size = new System.Drawing.Size(296, 327);
            this.tabMingeTools.TabIndex = 23;
            this.tabMingeTools.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabMingeTools_Selecting);
            // 
            // pageChatBomb
            // 
            this.pageChatBomb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pageChatBomb.Controls.Add(this.lblMingeCounterCB);
            this.pageChatBomb.Controls.Add(this.cmbThreadCountCB);
            this.pageChatBomb.Controls.Add(this.label4);
            this.pageChatBomb.Controls.Add(this.label3);
            this.pageChatBomb.Controls.Add(this.label2);
            this.pageChatBomb.Controls.Add(this.label1);
            this.pageChatBomb.Controls.Add(this.txtSteamID64CB);
            this.pageChatBomb.Controls.Add(this.txtMessagesCB);
            this.pageChatBomb.Controls.Add(this.btnStopCB);
            this.pageChatBomb.Controls.Add(this.btnStartCB);
            this.pageChatBomb.Controls.Add(this.txtIntervalCB);
            this.pageChatBomb.Location = new System.Drawing.Point(4, 22);
            this.pageChatBomb.Name = "pageChatBomb";
            this.pageChatBomb.Padding = new System.Windows.Forms.Padding(3);
            this.pageChatBomb.Size = new System.Drawing.Size(288, 301);
            this.pageChatBomb.TabIndex = 0;
            this.pageChatBomb.Text = "Chat Bomb";
            this.pageChatBomb.UseVisualStyleBackColor = true;
            // 
            // lblMingeCounterCB
            // 
            this.lblMingeCounterCB.Location = new System.Drawing.Point(8, 247);
            this.lblMingeCounterCB.Name = "lblMingeCounterCB";
            this.lblMingeCounterCB.Size = new System.Drawing.Size(274, 16);
            this.lblMingeCounterCB.TabIndex = 25;
            this.lblMingeCounterCB.Text = "Total Messages Sent: 0";
            this.lblMingeCounterCB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbThreadCountCB
            // 
            this.cmbThreadCountCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThreadCountCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbThreadCountCB.FormattingEnabled = true;
            this.cmbThreadCountCB.Items.AddRange(new object[] {
            "1",
            "4",
            "12"});
            this.cmbThreadCountCB.Location = new System.Drawing.Point(7, 76);
            this.cmbThreadCountCB.Name = "cmbThreadCountCB";
            this.cmbThreadCountCB.Size = new System.Drawing.Size(121, 21);
            this.cmbThreadCountCB.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Threads:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Victim (SteamID 64):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Messages (Different messages on new line):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Interval (MS):";
            // 
            // txtSteamID64CB
            // 
            this.txtSteamID64CB.Location = new System.Drawing.Point(8, 24);
            this.txtSteamID64CB.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtSteamID64CB.Name = "txtSteamID64CB";
            this.txtSteamID64CB.Size = new System.Drawing.Size(274, 20);
            this.txtSteamID64CB.TabIndex = 1;
            // 
            // txtMessagesCB
            // 
            this.txtMessagesCB.Location = new System.Drawing.Point(8, 134);
            this.txtMessagesCB.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtMessagesCB.Multiline = true;
            this.txtMessagesCB.Name = "txtMessagesCB";
            this.txtMessagesCB.Size = new System.Drawing.Size(274, 107);
            this.txtMessagesCB.TabIndex = 4;
            this.txtMessagesCB.WordWrap = false;
            // 
            // btnStopCB
            // 
            this.btnStopCB.Location = new System.Drawing.Point(7, 268);
            this.btnStopCB.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnStopCB.Name = "btnStopCB";
            this.btnStopCB.Size = new System.Drawing.Size(275, 27);
            this.btnStopCB.TabIndex = 6;
            this.btnStopCB.Text = "Stop";
            this.btnStopCB.UseVisualStyleBackColor = true;
            this.btnStopCB.Visible = false;
            this.btnStopCB.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStartCB
            // 
            this.btnStartCB.Location = new System.Drawing.Point(10, 268);
            this.btnStartCB.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnStartCB.Name = "btnStartCB";
            this.btnStartCB.Size = new System.Drawing.Size(272, 27);
            this.btnStartCB.TabIndex = 5;
            this.btnStartCB.Text = "Start";
            this.btnStartCB.UseVisualStyleBackColor = true;
            this.btnStartCB.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtIntervalCB
            // 
            this.txtIntervalCB.Location = new System.Drawing.Point(161, 76);
            this.txtIntervalCB.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtIntervalCB.Name = "txtIntervalCB";
            this.txtIntervalCB.Size = new System.Drawing.Size(121, 20);
            this.txtIntervalCB.TabIndex = 3;
            this.txtIntervalCB.Text = "80";
            // 
            // pageInviteSpam
            // 
            this.pageInviteSpam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pageInviteSpam.Controls.Add(this.lblMingeCounterIS);
            this.pageInviteSpam.Controls.Add(this.cmbThreadCountIS);
            this.pageInviteSpam.Controls.Add(this.label6);
            this.pageInviteSpam.Controls.Add(this.label7);
            this.pageInviteSpam.Controls.Add(this.label8);
            this.pageInviteSpam.Controls.Add(this.txtIntervalIS);
            this.pageInviteSpam.Controls.Add(this.txtSteamID64IS);
            this.pageInviteSpam.Controls.Add(this.btnStopIS);
            this.pageInviteSpam.Controls.Add(this.btnStartIS);
            this.pageInviteSpam.Location = new System.Drawing.Point(4, 22);
            this.pageInviteSpam.Name = "pageInviteSpam";
            this.pageInviteSpam.Padding = new System.Windows.Forms.Padding(3);
            this.pageInviteSpam.Size = new System.Drawing.Size(288, 301);
            this.pageInviteSpam.TabIndex = 1;
            this.pageInviteSpam.Text = "Invite Spam";
            this.pageInviteSpam.UseVisualStyleBackColor = true;
            // 
            // lblMingeCounterIS
            // 
            this.lblMingeCounterIS.Location = new System.Drawing.Point(7, 104);
            this.lblMingeCounterIS.Name = "lblMingeCounterIS";
            this.lblMingeCounterIS.Size = new System.Drawing.Size(274, 16);
            this.lblMingeCounterIS.TabIndex = 34;
            this.lblMingeCounterIS.Text = "Total Invites Sent: 0";
            this.lblMingeCounterIS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbThreadCountIS
            // 
            this.cmbThreadCountIS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThreadCountIS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbThreadCountIS.FormattingEnabled = true;
            this.cmbThreadCountIS.Items.AddRange(new object[] {
            "1",
            "4",
            "12"});
            this.cmbThreadCountIS.Location = new System.Drawing.Point(7, 76);
            this.cmbThreadCountIS.Name = "cmbThreadCountIS";
            this.cmbThreadCountIS.Size = new System.Drawing.Size(121, 21);
            this.cmbThreadCountIS.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Threads:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Victim (SteamID 64):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Interval (MS):";
            // 
            // txtIntervalIS
            // 
            this.txtIntervalIS.Location = new System.Drawing.Point(161, 76);
            this.txtIntervalIS.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtIntervalIS.Name = "txtIntervalIS";
            this.txtIntervalIS.Size = new System.Drawing.Size(121, 20);
            this.txtIntervalIS.TabIndex = 3;
            this.txtIntervalIS.Text = "80";
            // 
            // txtSteamID64IS
            // 
            this.txtSteamID64IS.Location = new System.Drawing.Point(8, 24);
            this.txtSteamID64IS.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtSteamID64IS.Name = "txtSteamID64IS";
            this.txtSteamID64IS.Size = new System.Drawing.Size(274, 20);
            this.txtSteamID64IS.TabIndex = 1;
            // 
            // btnStopIS
            // 
            this.btnStopIS.Location = new System.Drawing.Point(7, 125);
            this.btnStopIS.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnStopIS.Name = "btnStopIS";
            this.btnStopIS.Size = new System.Drawing.Size(275, 27);
            this.btnStopIS.TabIndex = 5;
            this.btnStopIS.Text = "Stop";
            this.btnStopIS.UseVisualStyleBackColor = true;
            this.btnStopIS.Visible = false;
            this.btnStopIS.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStartIS
            // 
            this.btnStartIS.Location = new System.Drawing.Point(7, 125);
            this.btnStartIS.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnStartIS.Name = "btnStartIS";
            this.btnStartIS.Size = new System.Drawing.Size(272, 27);
            this.btnStartIS.TabIndex = 4;
            this.btnStartIS.Text = "Start";
            this.btnStartIS.UseVisualStyleBackColor = true;
            this.btnStartIS.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrLoop
            // 
            this.tmrLoop.Enabled = true;
            this.tmrLoop.Tick += new System.EventHandler(this.tmrLoop_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.friendsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(296, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // friendsToolStripMenuItem
            // 
            this.friendsToolStripMenuItem.Name = "friendsToolStripMenuItem";
            this.friendsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.friendsToolStripMenuItem.Text = "Friends";
            this.friendsToolStripMenuItem.Click += new System.EventHandler(this.friendsToolStripMenuItem_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlTitle.Controls.Add(this.lblStatus);
            this.pnlTitle.Controls.Add(this.picAvatar);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 24);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(296, 64);
            this.pnlTitle.TabIndex = 25;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 415);
            this.Controls.Add(this.tabMingeTools);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Steam Minge";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_Closed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.tabMingeTools.ResumeLayout(false);
            this.pageChatBomb.ResumeLayout(false);
            this.pageChatBomb.PerformLayout();
            this.pageInviteSpam.ResumeLayout(false);
            this.pageInviteSpam.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Timer tmrInit;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TabPage pageChatBomb;
        private System.Windows.Forms.TabPage pageInviteSpam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrLoop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem friendsToolStripMenuItem;
        public System.Windows.Forms.TextBox txtSteamID64CB;
        public System.Windows.Forms.TextBox txtSteamID64IS;
        public System.Windows.Forms.TabControl tabMingeTools;
        public System.Windows.Forms.Label lblMingeCounterCB;
        public System.Windows.Forms.ComboBox cmbThreadCountCB;
        public System.Windows.Forms.TextBox txtMessagesCB;
        public System.Windows.Forms.Button btnStopCB;
        public System.Windows.Forms.Button btnStartCB;
        public System.Windows.Forms.TextBox txtIntervalCB;
        public System.Windows.Forms.Label lblMingeCounterIS;
        public System.Windows.Forms.ComboBox cmbThreadCountIS;
        public System.Windows.Forms.TextBox txtIntervalIS;
        public System.Windows.Forms.Button btnStopIS;
        public System.Windows.Forms.Button btnStartIS;
        private System.Windows.Forms.Panel pnlTitle;
    }
}