using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SIBAU_liblink.Login_Form;

namespace SIBAU_liblink
{
    public partial class Profile_fac_Control : UserControl
    {
        public Profile_fac_Control()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            UserInfo();

            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Region = new Region(GetCirclePath(pictureBox4.ClientRectangle));
        }
        private GraphicsPath GetCirclePath(Rectangle rect)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(rect);
            return path;
        }
        public void UserInfo()
        {
            pictureBox4.Image = sessionData.profile;

            textBox8.PlaceholderText = sessionData.UserID;
            textBox8.Enabled = false;
            textBox9.PlaceholderText = sessionData.UserfName;
            textBox9.Enabled = false;

        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pictureBox4.Width, pictureBox4.Height);
            pictureBox4.Region = new Region(path);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
