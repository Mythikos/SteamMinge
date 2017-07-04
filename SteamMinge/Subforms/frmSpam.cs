using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SteamMinge.Classes;

namespace SteamMinge
{
    public partial class frmSpam : Form
    {
        public frmSpam(string Message)
        {
            InitializeComponent();

            // Set the message
            this.lblMessage.Text = Message;

            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;

            List<Bitmap> ImageResources = new List<Bitmap>();
                ImageResources.Add(SteamMinge.Properties.Resources.brian);
                ImageResources.Add(SteamMinge.Properties.Resources.derp_girl);
                ImageResources.Add(SteamMinge.Properties.Resources.hank_hill);
                ImageResources.Add(SteamMinge.Properties.Resources.tweece);

            Random rand = new Random(Guid.NewGuid().GetHashCode());
            this.BackgroundImage = ImageResources[rand.Next(0, ImageResources.ToArray().Length)];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmrResize_Tick(object sender, EventArgs e)
        {
            // Make it huge o.O?
            ControlHelper.SizeLabelFont(this.lblMessage);
            this.tmrResize.Enabled = false;
        }

        private void frmSpam_Load(object sender, EventArgs e)
        {

        }
    }
}
