using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Image fakeImage = new Bitmap(1, 1);
            Graphics graphics = Graphics.FromImage(fakeImage);

            SizeF extent = graphics.MeasureString(this.lblMessage.Text, this.lblMessage.Font);

            float hRatio = this.lblMessage.Height / extent.Height;
            float wRatio = this.lblMessage.Width / extent.Width;
            float ratio = (hRatio < wRatio) ? hRatio : wRatio;

            float newSize = this.lblMessage.Font.Size * ratio;

            this.lblMessage.Font = new Font(this.lblMessage.Font.FontFamily, newSize, this.lblMessage.Font.Style);

            this.tmrResize.Enabled = false;
        }

        private void frmSpam_Load(object sender, EventArgs e)
        {

        }
    }
}
