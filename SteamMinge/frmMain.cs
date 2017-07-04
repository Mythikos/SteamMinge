using System;
using System.Windows.Forms;
using Steamworks;
using System.Threading;
using System.Collections.Generic;
using SteamMinge.Classes;
using System.IO;

namespace SteamMinge
{
    public partial class frmMain : Form
    {
        private bool _Initialized = false;
        private List<Thread> _BombThreads = new List<Thread>();
        private int _TotalMessagesSent = 0;

        public frmMain()
        {
            InitializeComponent();

            // Set the forms control state
            SetControlStatus(false);
            this.btnStart.Visible = true;
            this.btnStart.Enabled = false;
            this.btnStop.Visible = false;

            this.cmbThreadCount.SelectedIndex = 0;
        }

        #region Control Events
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Initialize the steam api
            _Initialized = SteamAPI.Init();
        }

        private void frmMain_Close(object sender, FormClosedEventArgs e)
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
            SetControlStatus(true);

            // Kill the threads
            foreach (Thread thread in _BombThreads)
                KillBombThread(thread);

            // Clear the bomb list
            _BombThreads.Clear();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Set the control states to disabled
            SetControlStatus(false);

            // Reset the total messages sent
            _TotalMessagesSent = 0;

            // Create the threads
            for (int i = 0; i < int.Parse(this.cmbThreadCount.Text); i++)
                _BombThreads.Add(CreateBombThread());

            // Start all threads
            foreach (Thread thread in _BombThreads)
                thread.Start();
        }

        private void cmbThreadCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.cmbThreadCount.Text))
            {
                int tCount = int.Parse(this.cmbThreadCount.Text);
                this.txtInterval.Text = (tCount * 80).ToString();
            }
        }

        private void btnFriends_Click(object sender, EventArgs e)
        {
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
            frmFriends nForm = new frmFriends(this.txtSteamID64, FriendList);
            nForm.Show();
        }
        #endregion

        #region Thread Methods
        private Thread CreateBombThread()
        {
            int Interval = int.Parse(this.txtInterval.Text);
            CSteamID sID = new CSteamID(ulong.Parse(this.txtSteamID64.Text));
            string[] Messages = this.txtMessages.Text.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            Thread thread = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        // Declare rand object
                        Random rand = new Random(Guid.NewGuid().GetHashCode());

                        if (DeveloperIsTarget(sID))
                        {
                            // No target teh developer ;D
                            Messages = ("Developers Developers Developers!" + Environment.NewLine + "Your Kung-Fu is weak." + Environment.NewLine + "I used to be an adventurer like you, then I took an arrow to the knee.").Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                            Invoke(new Action(() =>
                            {
                                frmSpam nForm = new frmSpam(Messages[rand.Next(0, Messages.Length)]);
                                nForm.StartPosition = FormStartPosition.Manual;
                                nForm.Location = Screen.AllScreens[rand.Next(0, Screen.AllScreens.Length)].WorkingArea.Location;
                                nForm.FormBorderStyle = FormBorderStyle.None;
                                nForm.WindowState = FormWindowState.Maximized;
                                nForm.Show();
                            }));

                            if (_TotalMessagesSent > 99)
                                Invoke(new Action(() => btnStop_Click(this, null)));
                        }
                        else
                        {
                            SteamFriends.ReplyToFriendMessage(sID, Messages[rand.Next(0, Messages.Length)]); // Send the message
                        }

                        // Increment message counter
                        _TotalMessagesSent++;

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

        #region Timer Methods
        private void tmrInit_Tick(object sender, EventArgs e)
        {
            if (_Initialized)
            {
                // Try to get/display avatar
                this.picAvatar.Image = Classes.ImageExtension.GetSteamAvatar(SteamUser.GetSteamID(), "Avatar", 32, 32);
                this.picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;

                // Set display stuff
                this.lblStatus.Text = "Logged in as " + SteamFriends.GetPersonaName();
                this.lblStatus.ForeColor = System.Drawing.Color.White;

                // Disable the timer, we have initialized
                this.tmrInit.Enabled = false;

                // Set control state
                SetControlStatus(true);
            }
            else
                _Initialized = SteamAPI.Init();
        }

        private void tmrLoop_Tick(object sender, EventArgs e)
        {
            // Update the total messages sent display
            this.lblMessageCount.Text = "Total Messages Sent: " + _TotalMessagesSent.ToString();
        }
        #endregion

        #region Helper Methods
        private void SetControlStatus(bool Enabled)
        {
            // Enable/Disable input
            this.txtMessages.Enabled = Enabled;
            this.txtInterval.Enabled = Enabled;
            this.txtSteamID64.Enabled = Enabled;
            this.cmbThreadCount.Enabled = Enabled;

            // Set button visibility
            this.btnStop.Visible = !Enabled;
            this.btnStop.Enabled = !Enabled;
            this.btnStart.Visible = Enabled;
            this.btnStart.Enabled = Enabled;
            this.btnFriends.Enabled = Enabled;
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
        #endregion
    }
}
