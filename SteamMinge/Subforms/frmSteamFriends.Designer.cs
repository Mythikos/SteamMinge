namespace SteamMinge
{
    partial class frmSteamFriends
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSteamFriends));
            this.gridFriends = new System.Windows.Forms.DataGridView();
            this.picAvatar = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSteamID64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridFriends)).BeginInit();
            this.SuspendLayout();
            // 
            // gridFriends
            // 
            this.gridFriends.AllowUserToAddRows = false;
            this.gridFriends.AllowUserToDeleteRows = false;
            this.gridFriends.AllowUserToResizeColumns = false;
            this.gridFriends.AllowUserToResizeRows = false;
            this.gridFriends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFriends.ColumnHeadersVisible = false;
            this.gridFriends.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.picAvatar,
            this.txtName,
            this.txtSteamID64});
            this.gridFriends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFriends.Location = new System.Drawing.Point(0, 46);
            this.gridFriends.Name = "gridFriends";
            this.gridFriends.ReadOnly = true;
            this.gridFriends.RowHeadersVisible = false;
            this.gridFriends.Size = new System.Drawing.Size(284, 215);
            this.gridFriends.TabIndex = 0;
            this.gridFriends.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFriends_CellDoubleClick);
            // 
            // picAvatar
            // 
            this.picAvatar.HeaderText = "Avatar";
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.ReadOnly = true;
            this.picAvatar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.picAvatar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.picAvatar.Width = 32;
            // 
            // txtName
            // 
            this.txtName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtName.HeaderText = "Name";
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            // 
            // txtSteamID64
            // 
            this.txtSteamID64.HeaderText = "SteamID64";
            this.txtSteamID64.Name = "txtSteamID64";
            this.txtSteamID64.ReadOnly = true;
            this.txtSteamID64.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Double click a friend to populate their SteamID 64";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSteamFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gridFriends);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSteamFriends";
            this.Text = "Friends List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFriends_Close);
            this.Load += new System.EventHandler(this.frmFriends_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFriends)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridFriends;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn picAvatar;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSteamID64;
    }
}