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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtLineBox = new System.Windows.Forms.TextBox();
            this.tmrInit = new System.Windows.Forms.Timer(this.components);
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.txtSteamID64 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbThreadCount = new System.Windows.Forms.ComboBox();
            this.btnFriends = new System.Windows.Forms.Button();
            this.lblMessageCount = new System.Windows.Forms.Label();
            this.tmrLoop = new System.Windows.Forms.Timer(this.components);
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.txtInterval = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.DarkCyan;
            this.lblStatus.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(64, 1);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(222, 45);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Steam Not Detected";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLineBox
            // 
            this.txtLineBox.BackColor = System.Drawing.Color.DarkCyan;
            this.txtLineBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLineBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLineBox.Enabled = false;
            this.txtLineBox.ForeColor = System.Drawing.Color.Black;
            this.txtLineBox.Location = new System.Drawing.Point(0, 0);
            this.txtLineBox.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtLineBox.Multiline = true;
            this.txtLineBox.Name = "txtLineBox";
            this.txtLineBox.Size = new System.Drawing.Size(296, 46);
            this.txtLineBox.TabIndex = 1;
            // 
            // tmrInit
            // 
            this.tmrInit.Enabled = true;
            this.tmrInit.Interval = 1000;
            this.tmrInit.Tick += new System.EventHandler(this.tmrInit_Tick);
            // 
            // txtMessages
            // 
            this.txtMessages.Location = new System.Drawing.Point(12, 182);
            this.txtMessages.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.Size = new System.Drawing.Size(274, 107);
            this.txtMessages.TabIndex = 2;
            this.txtMessages.WordWrap = false;
            // 
            // txtSteamID64
            // 
            this.txtSteamID64.Location = new System.Drawing.Point(12, 72);
            this.txtSteamID64.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtSteamID64.Name = "txtSteamID64";
            this.txtSteamID64.Size = new System.Drawing.Size(184, 23);
            this.txtSteamID64.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Interval (MS):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Messages (Different messages on new line):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Victim (SteamID 64):";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(14, 316);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(272, 27);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(11, 316);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(275, 27);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Threads:";
            // 
            // cmbThreadCount
            // 
            this.cmbThreadCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThreadCount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbThreadCount.FormattingEnabled = true;
            this.cmbThreadCount.Items.AddRange(new object[] {
            "1",
            "4",
            "12"});
            this.cmbThreadCount.Location = new System.Drawing.Point(11, 124);
            this.cmbThreadCount.Name = "cmbThreadCount";
            this.cmbThreadCount.Size = new System.Drawing.Size(121, 24);
            this.cmbThreadCount.TabIndex = 11;
            this.cmbThreadCount.SelectedIndexChanged += new System.EventHandler(this.cmbThreadCount_SelectedIndexChanged);
            // 
            // btnFriends
            // 
            this.btnFriends.Location = new System.Drawing.Point(211, 72);
            this.btnFriends.Name = "btnFriends";
            this.btnFriends.Size = new System.Drawing.Size(75, 23);
            this.btnFriends.TabIndex = 12;
            this.btnFriends.Text = "Friends";
            this.btnFriends.UseVisualStyleBackColor = true;
            this.btnFriends.Click += new System.EventHandler(this.btnFriends_Click);
            // 
            // lblMessageCount
            // 
            this.lblMessageCount.Location = new System.Drawing.Point(12, 295);
            this.lblMessageCount.Name = "lblMessageCount";
            this.lblMessageCount.Size = new System.Drawing.Size(274, 16);
            this.lblMessageCount.TabIndex = 13;
            this.lblMessageCount.Text = "Total Messages Sent: 0";
            this.lblMessageCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrLoop
            // 
            this.tmrLoop.Enabled = true;
            this.tmrLoop.Tick += new System.EventHandler(this.tmrLoop_Tick);
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.DarkCyan;
            this.picAvatar.Location = new System.Drawing.Point(20, 7);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(32, 32);
            this.picAvatar.TabIndex = 14;
            this.picAvatar.TabStop = false;
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(165, 124);
            this.txtInterval.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(121, 23);
            this.txtInterval.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 352);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.lblMessageCount);
            this.Controls.Add(this.btnFriends);
            this.Controls.Add(this.cmbThreadCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.txtSteamID64);
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtLineBox);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "frmMain";
            this.Text = "Chat Bomb";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_Close);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtLineBox;
        private System.Windows.Forms.Timer tmrInit;
        private System.Windows.Forms.TextBox txtMessages;
        private System.Windows.Forms.TextBox txtSteamID64;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbThreadCount;
        private System.Windows.Forms.Button btnFriends;
        private System.Windows.Forms.Label lblMessageCount;
        private System.Windows.Forms.Timer tmrLoop;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.TextBox txtInterval;
    }
}

