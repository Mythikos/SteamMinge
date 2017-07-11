using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Steamworks;
using SteamMinge.Classes;
using System.Drawing;
using System.IO;
using System.Linq;

namespace SteamMinge
{
    public partial class frmSteamFriends : Form
    {
        private Dictionary<CSteamID, string> _FriendsList;

        public frmSteamFriends(Dictionary<CSteamID, string> FriendsList)
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
            foreach (KeyValuePair<CSteamID, string> Friend in _FriendsList.OrderBy(kv => kv.Value))
            {
                Image img = ImageExtension.GetSteamAvatar(Friend.Key, @"friends\" + Friend.Key.ToString(), 32, 32);
                this.gridFriends.Rows.Add(new object[] { img, Friend.Value, Friend.Key});
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
