using SteamMinge.Classes;
using Steamworks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamMinge
{
    public partial class frmMain : Form
    {
        #region Variable Declaration
        // app status vars
        private bool _Initialized = false;

        // mingery items
        private List<Thread> _Threads = new List<Thread>();
        private int _TotalCount = 0;

        // tab related
        public int CurrentTabIndex = 0;
        private bool _PreventTabNavigation = false;
        private string _ControlSuffix = "";
        #endregion

        #region Constructors
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region Control Methods
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Force a tab change
            TabMingeTools_Selecting(this, null);

            // Initialize controls 
            SetControlStatus(false);
            ControlHelper.GetControlBySuffixedName(this, "btnStop", _ControlSuffix).Visible = false;
            ControlHelper.GetControlBySuffixedName(this, "btnStop", _ControlSuffix).Enabled = false;

            // Size status label
            //ControlHelper.SizeLabelFont(this.lblStatus);
        }

        private void frmMain_Closed(object sender, FormClosedEventArgs e)
        {
            // Close all forms that are currently open that isnt our main form
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                if (Application.OpenForms[i].Name != this.Name)
                    Application.OpenForms[i].Close();

            // Clear the message directories
            ImageExtension.DeleteFilesInDirectory(Directory.GetCurrentDirectory() + @"\images", "bmp");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // Enable the controls
            SetControlStatus(true, false);

            // Kill the threads
            foreach (Thread thread in _Threads)
                KillBombThread(thread);

            // Clear the bomb list
            _Threads.Clear();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Set the control states to disabled
            SetControlStatus(false, true);

            // Reset the total messages sent
            _TotalCount = 0;

            // Get control values
            Control ThreadCountControl = ControlHelper.GetControlBySuffixedName(this, "cmbThreadCount", _ControlSuffix);
            Control IntervalControl = ControlHelper.GetControlBySuffixedName(this, "txtInterval", _ControlSuffix);
            Control SteamID64Control = ControlHelper.GetControlBySuffixedName(this, "txtSteamID64", _ControlSuffix);

            // Create the threads
            for (int i = 0; i < int.Parse(ThreadCountControl.Text); i++)
                _Threads.Add(CreateBombThread(IntervalControl.Text, SteamID64Control.Text));

            // Start all threads
            foreach (Thread thread in _Threads)
                thread.Start();
        }

        private void TabMingeTools_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (_PreventTabNavigation)
            {
                e.Cancel = true;
                return;
            }

            // Set the new page
            CurrentTabIndex = this.tabMingeTools.SelectedIndex; //e.TabPageIndex;

            if (CurrentTabIndex == Constants.TabIndexes.ChatBomb)
                _ControlSuffix = "CB";
            else if (CurrentTabIndex == Constants.TabIndexes.InviteSpam)
                _ControlSuffix = "IS";
        }
        #endregion

        #region Timer Method
        private void tmrInit_Tick(object sender, EventArgs e)
        {
            if (_Initialized)
            {
                // Try to get/display avatar
                this.picAvatar.Image = Classes.ImageExtension.GetSteamAvatar(SteamUser.GetSteamID(), "Avatar", 64, 64);
                this.picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;

                // Set display stuff
                this.lblStatus.Text = "Logged in as " + SteamFriends.GetPersonaName();
                this.lblStatus.ForeColor = System.Drawing.Color.White;
                ControlHelper.SizeLabelFont(this.lblStatus);

                // Disable the timer, we have initialized
                this.tmrInit.Enabled = false;

                // Enable form controls
                SetControlStatus(true);
            }
            else
                _Initialized = SteamAPI.Init();
        }

        private void tmrLoop_Tick(object sender, EventArgs e)
        {
            Label lblCount = (Label)ControlHelper.GetControlBySuffixedName(this, "lblMingeCounter", _ControlSuffix);
            lblCount.Text = lblCount.Text.Substring(0, lblCount.Text.IndexOf(":", StringComparison.Ordinal)) + ": " + _TotalCount.ToString();
        }
        #endregion

        #region Thread Methods
        private Thread CreateBombThread(string IntervalString, string SteamID64)
        {
            int Interval = int.Parse(IntervalString);
            CSteamID sID = new CSteamID(ulong.Parse(SteamID64));

            Thread thread = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        if (DeveloperIsTarget(sID))
                        {
                            CreateLocalSpam();

                            if (_TotalCount > 99)
                                Invoke(new Action(() => btnStop_Click(this, null)));
                        }
                        else
                        {
                            if (CurrentTabIndex == Constants.TabIndexes.ChatBomb)
                            {
                                Random rand = new Random(Guid.NewGuid().GetHashCode());
                                TextBox MessagesEntry = default(TextBox);
                                Invoke(new Action(() => MessagesEntry = (TextBox)ControlHelper.GetControlBySuffixedName(this, "txtMessages", _ControlSuffix) ));

                                string[] Messages = MessagesEntry.Text.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                                SteamFriends.ReplyToFriendMessage(sID, Messages[rand.Next(0, Messages.Length)]);
                            }
                            else if (CurrentTabIndex == Constants.TabIndexes.InviteSpam)
                            {
                                SteamFriends.InviteUserToGame(sID, "");
                            }
                        }

                        // Increment message counter
                        _TotalCount++;

                        // Sleep the thread for the time specified in the interval
                        Thread.Sleep(Interval);
                    }
                }
                catch { }
            });

            return thread;
        }

        private void KillBombThread(Thread thread)
        {
            thread.Abort();
        }
        #endregion

        #region Helper Methods
        private void SetControlStatus(bool Enabled, bool PreventTabNavigation = false)
        {
            // Enable/Disable controls
            //this.tabMingeTools.Enabled = Enabled;
            this.friendsToolStripMenuItem.Enabled = Enabled;
            ControlHelper.GetControlBySuffixedName(this, "btnStop", _ControlSuffix).Visible = !Enabled;
            ControlHelper.GetControlBySuffixedName(this, "btnStop", _ControlSuffix).Enabled = !Enabled;
            ControlHelper.GetControlBySuffixedName(this, "btnStart", _ControlSuffix).Enabled = Enabled;

            // Enable/disable navigation (Program must be running?)
            _PreventTabNavigation = PreventTabNavigation;
            this.tmrLoop.Enabled = PreventTabNavigation;
        }

        private bool DeveloperIsTarget(CSteamID sID)
        {
            // Vincent's Steam ID
            CSteamID DeveloperID = new CSteamID(ulong.Parse("76561198057393795"));

            if (sID == DeveloperID)
                return true;
            else
                return false;
        }

        private void CreateLocalSpam()
        {
            // No target teh developer ;D
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            string[] Messages = ("Developers Developers Developers!" + Environment.NewLine + "Your Kung-Fu is weak." + Environment.NewLine + "I used to be an adventurer like you, then I took an arrow to the knee.").Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            Invoke(new Action(() =>
            {
                frmSpam nForm = new frmSpam(Messages[rand.Next(0, Messages.Length)]);
                nForm.StartPosition = FormStartPosition.Manual;
                nForm.Location = Screen.AllScreens[rand.Next(0, Screen.AllScreens.Length)].WorkingArea.Location;
                nForm.FormBorderStyle = FormBorderStyle.None;
                nForm.WindowState = FormWindowState.Maximized;
                nForm.Show(this);
            }));
        }
        #endregion

        #region SubForm Methods
        public void CloseFriendForm()
        {
            // Close all forms that are currently open that isnt our main form
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                if (Application.OpenForms[i].Name == "frmSteamFriends")
                    Application.OpenForms[i].Close();
        }

        private void friendsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the friend form if it is open
            CloseFriendForm();

            // Create local variables
            SortedDictionary<string, CSteamID> FriendList = new SortedDictionary<string, CSteamID>();
            int iCount = SteamFriends.GetFriendCount(EFriendFlags.k_EFriendFlagImmediate);

            // Get the friend list
            for (int i = 0; i < iCount; ++i)
            {
                CSteamID sID = SteamFriends.GetFriendByIndex(i, EFriendFlags.k_EFriendFlagImmediate);
                FriendList.Add(SteamFriends.GetFriendPersonaName(sID).ToString(), sID);
            }

            // Open friend list
            frmSteamFriends nForm = new frmSteamFriends(FriendList);
            nForm.Show(this);
        }
        #endregion
    }
}
