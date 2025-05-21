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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            LoadUserControl(new Dashboard_fac_Control());
            button1.Click += (s, e) => ctms.Show(button1, 20, button1.Height);

            label2.Text = sessionData.UserfName;
            pictureBox3.Image = sessionData.profile;

            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Region = new Region(GetCirclePath(pictureBox3.ClientRectangle));
        }
        private bool isSidebarVisible = true;
        private GraphicsPath GetCirclePath(Rectangle rect)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(rect);
            return path;
        }
        private void LoadUserControl(UserControl userControl)
        {
            panel_Container.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panel_Container.Controls.Add(userControl);
        }

        private void btn_db_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Dashboard_fac_Control());
        }

        private void btn_sbk_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Search_bks_fac_Control());
        }

        private void btn_rbk_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Return_bks_fac_Control());
        }

        private void btn_fines_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Fines_fac_Control());
        }

        private void btn_prf_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Profile_fac_Control());
        }

        private void btn_abt_Click(object sender, EventArgs e)
        {
            LoadUserControl(new About_fac_Control());
        }

        private void btn_sbar_Click(object sender, EventArgs e)
        {
            if (isSidebarVisible)
            {
                panel_sbar.Visible = false;
            }
            else
            {
                panel_sbar.Visible = true;
            }
            isSidebarVisible = !isSidebarVisible;
        }

        private void tsmi_lg_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Form4 f4 = new Form4();
            f4.Hide();
        }

        private void btn_db_MouseEnter(object sender, EventArgs e)
        {
            this.btn_db.ForeColor = Color.FromArgb(69, 170, 242);
        }

        private void btn_db_MouseLeave(object sender, EventArgs e)
        {
            this.btn_db.ForeColor = Color.White;
        }

        private void btn_sbk_MouseEnter(object sender, EventArgs e)
        {
            this.btn_sbk.ForeColor = Color.FromArgb(69, 170, 242);
        }

        private void btn_sbk_MouseLeave(object sender, EventArgs e)
        {
            this.btn_sbk.ForeColor = Color.White;
        }

        private void btn_bbks_MouseEnter(object sender, EventArgs e)
        {
            this.btn_bbks.ForeColor = Color.FromArgb(69, 170, 242);
        }

        private void btn_bbks_MouseLeave(object sender, EventArgs e)
        {
            this.btn_bbks.ForeColor = Color.White;
        }

        private void btn_rbk_MouseEnter(object sender, EventArgs e)
        {
            this.btn_rbk.ForeColor = Color.FromArgb(69, 170, 242);
        }

        private void btn_rbk_MouseLeave(object sender, EventArgs e)
        {
            this.btn_rbk.ForeColor = Color.White;
        }

        private void btn_fines_MouseEnter(object sender, EventArgs e)
        {
            this.btn_fines.ForeColor = Color.FromArgb(69, 170, 242);
        }

        private void btn_fines_MouseLeave(object sender, EventArgs e)
        {
            this.btn_fines.ForeColor = Color.White;
        }

        private void btn_prf_MouseEnter(object sender, EventArgs e)
        {
            this.btn_prf.ForeColor = Color.FromArgb(69, 170, 242);
        }

        private void btn_prf_MouseLeave(object sender, EventArgs e)
        {
            this.btn_prf.ForeColor = Color.White;
        }

        private void btn_abt_MouseEnter(object sender, EventArgs e)
        {
            this.btn_abt.ForeColor = Color.FromArgb(69, 170, 242);
        }

        private void btn_abt_MouseLeave(object sender, EventArgs e)
        {
            this.btn_abt.ForeColor = Color.White;
        }

        private void btn_bbks_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Borrowed_bks_fac_Control());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pictureBox3.Width, pictureBox3.Height);
            pictureBox3.Region = new Region(path);
        }
    }
}
