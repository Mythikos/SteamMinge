using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Steamworks;
using SteamMinge.Classes;
using System.Drawing;
using System.IO;

namespace SteamMinge
{
    public partial class frmFriends : Form
    {
        private TextBox _SteamID64TextBox;
        private SortedDictionary<string, CSteamID> _FriendsList;

        public frmFriends(TextBox SteamID64TextBox, SortedDictionary<string, CSteamID> FriendsList)
        {
            // Assign globals
            _SteamID64TextBox = SteamID64TextBox;
            _FriendsList = FriendsList;

            // Initialize the components
            InitializeComponent();
        }

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
            // Blank the text box out
            _SteamID64TextBox.Text = "";

            // Get the value in the third column (2, zero based) cause it should be our steam id and assign to text box 
            _SteamID64TextBox.Text = gridFriends[2, e.RowIndex].Value.ToString();
        }
    }
}
