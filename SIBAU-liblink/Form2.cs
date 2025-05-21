using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using static SIBAU_liblink.Login_Form;
namespace SIBAU_liblink
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadUserControl(new Dashboard_Control());
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
        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }

        private void LoadUserControl(UserControl userControl)
        {
            panel_Container.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panel_Container.Controls.Add(userControl);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tsmi_lg_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Form2 f2 = new Form2();
            f2.Hide();
        }

        private void btn_abt_Click(object sender, EventArgs e)
        {
            LoadUserControl(new About_Control());
        }

        private void btn_mbk_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Manage_bks_Control());
        }

        private void btn_db_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Dashboard_Control());
        }

        private void btn_ibk_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Issue_bks_Control());
        }

        private void btn_rbk_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Return_bks_Control());
        }

        private void btn_bbk_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Borrowed_bks_Control());
        }

        private void btn_tbk_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Total_bks_Control());
        }

        private void btn_tms_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Total_mbs_Control());
        }

        private void btn_rpt_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Report_Control());
        }

        private void btn_sbk_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Search_bks_Control());
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

        private void panel_Container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_db_MouseEnter(object sender, EventArgs e)
        {
            this.btn_db.ForeColor = Color.FromArgb(69, 170, 242);
        }

        private void btn_db_MouseLeave(object sender, EventArgs e)
        {
            this.btn_db.ForeColor = Color.White;
        }

        private void btn_mbk_MouseEnter(object sender, EventArgs e)
        {
            this.btn_mbk.ForeColor = Color.FromArgb(69, 170, 242);
        }

        private void btn_mbk_MouseLeave(object sender, EventArgs e)
        {
            this.btn_mbk.ForeColor = Color.White;
        }

        private void btn_sbk_MouseEnter(object sender, EventArgs e)
        {
            this.btn_sbk.ForeColor = Color.FromArgb(69, 170, 242);
        }

        private void btn_sbk_MouseLeave(object sender, EventArgs e)
        {
            this.btn_sbk.ForeColor = Color.White;
        }

        private void btn_ibk_MouseEnter(object sender, EventArgs e)
        {
            this.btn_ibk.ForeColor = Color.FromArgb(69, 170, 242);
        }

        private void btn_ibk_MouseLeave(object sender, EventArgs e)
        {
            this.btn_ibk.ForeColor = Color.White;
        }

        private void btn_rbk_MouseEnter(object sender, EventArgs e)
        {
            this.btn_rbk.ForeColor = Color.FromArgb(69, 170, 242);
        }

        private void btn_rbk_MouseLeave(object sender, EventArgs e)
        {
            this.btn_rbk.ForeColor = Color.White;
        }

        private void btn_bbk_MouseEnter(object sender, EventArgs e)
        {
            this.btn_bbk.ForeColor = Color.FromArgb(69, 170, 242);
        }

        private void btn_bbk_MouseLeave(object sender, EventArgs e)
        {
            this.btn_bbk.ForeColor = Color.White;
        }

        private void btn_tbk_MouseEnter(object sender, EventArgs e)
        {
            this.btn_tbk.ForeColor = Color.FromArgb(69, 170, 242);
        }

        private void btn_tbk_MouseLeave(object sender, EventArgs e)
        {
            this.btn_tbk.ForeColor = Color.White;
        }

        private void btn_tms_MouseEnter(object sender, EventArgs e)
        {
            this.btn_tms.ForeColor = Color.FromArgb(69, 170, 242);
        }

        private void btn_tms_MouseLeave(object sender, EventArgs e)
        {
            this.btn_tms.ForeColor = Color.White;
        }

        private void btn_rpt_MouseEnter(object sender, EventArgs e)
        {
            this.btn_rpt.ForeColor = Color.FromArgb(69, 170, 242);
        }

        private void btn_rpt_MouseLeave(object sender, EventArgs e)
        {
            this.btn_rpt.ForeColor = Color.White;
        }

        private void btn_abt_MouseEnter(object sender, EventArgs e)
        {
            btn_abt.ForeColor = Color.FromArgb(69, 170, 242);
        }

        private void btn_abt_MouseLeave(object sender, EventArgs e)
        {
            this.btn_abt.ForeColor = Color.White;
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pictureBox3.Width, pictureBox3.Height);
            pictureBox3.Region = new Region(path);
        }
    }
}
