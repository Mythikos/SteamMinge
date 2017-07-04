using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Steamworks;
using SteamMinge.Classes;
using System.Drawing;
using System.IO;

namespace SteamMinge
{
    public partial class frmSteamFriends : Form
    {
        private SortedDictionary<string, CSteamID> _FriendsList;

        public frmSteamFriends(SortedDictionary<string, CSteamID> FriendsList)
        {
            // Assign globals
            _FriendsList = FriendsList;

            // Initialize the components
            InitializeComponent();
        }

        #region Control Methods
        private void frmFriends_Load(object sender, EventArgs e)
        {
            // Loop through all of the friends and add them to the data grid
            foreach (KeyValuePair<string, CSteamID> Friend in _FriendsList)
            {
                Image img = ImageExtension.GetSteamAvatar(Friend.Value, @"friends\" + Friend.Value.ToString(), 32, 32);
                this.gridFriends.Rows.Add(new object[] { img, Friend.Key, Friend.Value });
            }
        }

        private void frmFriends_Close(object sender, FormClosedEventArgs e)
        {
            // Delete all images in friends directory
            ImageExtension.DeleteFilesInDirectory(Directory.GetCurrentDirectory() + @"\images\friends", "bmp");
        }

        private void gridFriends_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Determine the text box to populate
            TextBox SteamID64Text = DetermineSteamIDBox();

            // Blank the text box out
            SteamID64Text.Text = "";

            // Get the value in the third column (2, zero based) cause it should be our steam id and assign to text box 
            SteamID64Text.Text = gridFriends[2, e.RowIndex].Value.ToString();

            // Close the form
            this.Close();
        }
        #endregion

        #region Helper Methods
        private TextBox DetermineSteamIDBox()
        {
            frmMain MainForm = (frmMain)this.Owner;

            if (MainForm.CurrentTabIndex == Constants.TabIndexes.ChatBomb)
                return MainForm.txtSteamID64CB;
            else if (MainForm.CurrentTabIndex == Constants.TabIndexes.InviteSpam)
                return MainForm.txtSteamID64IS;

            return null;
        }
        #endregion
    }
}
