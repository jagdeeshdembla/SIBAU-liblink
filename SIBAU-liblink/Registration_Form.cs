using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Drawing.Drawing2D;
using System.Net.NetworkInformation;
using static SIBAU_liblink.Login_Form;

namespace SIBAU_liblink
{
    public partial class Registration_Form : Form
    {
        ToolTip tooltip = new ToolTip();
        byte[] profileImage = null;
        public Registration_Form()
        {
            InitializeComponent();
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Region = new Region(GetCirclePath(pictureBox4.ClientRectangle));

        }
        private GraphicsPath GetCirclePath(Rectangle rect)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(rect);
            return path;
        }

        private void textBox5_MouseHover(object sender, EventArgs e)
        {

            if (textBox5.PlaceholderText == "First Name")
            {
                textBox5.PlaceholderText = "";
                textBox5.ForeColor = Color.Black;
                tooltip.SetToolTip(textBox5, "Enter Your Firt Name");

            }
        }

        private void textBox5_MouseLeave(object sender, EventArgs e)
        {
            if (textBox5.PlaceholderText == "")
            {
                textBox5.PlaceholderText = "First Name";
                textBox5.ForeColor = Color.Black;


            }
        }

        private void textBox7_MouseHover(object sender, EventArgs e)
        {
            if (textBox7.PlaceholderText == "Last Name")
            {
                textBox7.PlaceholderText = "";
                textBox7.ForeColor = Color.Black;
                tooltip.SetToolTip(textBox7, "Enter Your Last Name");

            }

        }

        private void textBox7_MouseLeave(object sender, EventArgs e)
        {
            if (textBox7.PlaceholderText == "")
            {
                textBox7.PlaceholderText = "Last Name";
                textBox7.ForeColor = Color.Black;

            }

        }

        private void textBox4_MouseHover(object sender, EventArgs e)
        {
            if (textBox4.PlaceholderText == "CMS-ID")
            {
                textBox4.PlaceholderText = "";
                textBox4.ForeColor = Color.Black;
                tooltip.SetToolTip(textBox4, "Enter Your CMS-ID");

            }


        }

        private void textBox4_MouseLeave(object sender, EventArgs e)
        {
            if (textBox4.PlaceholderText == "")
            {
                textBox4.PlaceholderText = "CMS-ID";
                textBox4.ForeColor = Color.Black;

            }

        }

        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            if (textBox3.PlaceholderText == "Email")
            {
                textBox3.PlaceholderText = "";
                textBox3.ForeColor = Color.Black;
                tooltip.SetToolTip(textBox3, "Enter Your Email");

            }
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            if (textBox3.PlaceholderText == "")
            {
                textBox3.PlaceholderText = "Email";
                textBox3.ForeColor = Color.Black;

            }

        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            if (textBox2.PlaceholderText == "Password")
            {
                textBox2.PlaceholderText = "";
                textBox2.ForeColor = Color.Black;
                tooltip.SetToolTip(textBox2, "Enter Your Password");
            }

        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            if (textBox2.PlaceholderText == "")
            {
                textBox2.PlaceholderText = "Password";
                textBox2.ForeColor = Color.Black;
            }


        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            if (textBox1.PlaceholderText == "Comfrim Password")
            {
                textBox1.PlaceholderText = "";
                textBox1.ForeColor = Color.Black;
                tooltip.SetToolTip(textBox1, "Enter Your Comfrim Password");
            }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.PlaceholderText == "")
            {
                textBox1.PlaceholderText = "Comfrim Password";
                textBox1.ForeColor = Color.Black;
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_Form login = new Login_Form();
            login.Show();
            Registration_Form register = new Registration_Form();
            register.Hide();
        }
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder hash = new StringBuilder();

                foreach (byte b in bytes)
                {
                    hash.Append(b.ToString("x2")); // Convert to hexadecimal
                }

                return hash.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String password = textBox2.Text;
            String hashedPassword = HashPassword(password);
            String comfrim_password = textBox1.Text;
            String hashedcomfrim_Password = HashPassword(password);


            String Gender = "";
            if (radioButton1.Checked)
            {
                Gender = radioButton1.Text;
            }
            else
            {
                Gender = radioButton2.Text;
            }
            String dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            string query = @"INSERT INTO UsersInfo(ID, FullName, Email, Department, Password,ComfrimPassword, UserType, Gender, ProfilePicture) 
                           VALUES(@ID, @fName, @Email, @Department, @Password,@ComfrimPassword, @UserType, @Gender, @ProfilePicture)";
            SqlConnection con = new SqlConnection(dcon);
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            cmd.Parameters.AddWithValue("@ID", textBox5.Text.Trim());
            cmd.Parameters.AddWithValue("@fName",textBox7.Text.Trim());
            cmd.Parameters.AddWithValue("@Email",textBox4.Text.Trim());
            cmd.Parameters.AddWithValue("@Department",textBox3.Text.Trim());
            cmd.Parameters.AddWithValue("@Password", hashedPassword.Trim());
            cmd.Parameters.AddWithValue("@ComfrimPassword",hashedcomfrim_Password.Trim());
            cmd.Parameters.AddWithValue("@UserType", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Gender",Gender);
            if (profileImage != null)
                cmd.Parameters.Add("@ProfilePicture", System.Data.SqlDbType.VarBinary).Value = profileImage;
            else
                cmd.Parameters.Add("@ProfilePicture", System.Data.SqlDbType.VarBinary).Value = DBNull.Value;

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Register Successfully");
            Clearfields();
            Login_Form login = new Login_Form();
            login.Show();

        }
        private void Clearfields()
        {
            textBox5.Clear();
            textBox7.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox2.Clear();
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;

          


        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.ForeColor = Color.White;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                hidden.BringToFront();
                textBox2.PasswordChar = '\0';
            }
        }

        private void hidden_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                pictureBox2.BringToFront();
                textBox2.PasswordChar = '*';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '*')
            {
                hidden1.BringToFront();
                textBox1.PasswordChar = '\0';
            }
        }

        private void hidden1_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '\0')
            {
                pictureBox1.BringToFront();
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_CP_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                
                pictureBox4.Image = Image.FromFile(ofd.FileName);
                

                using (var tempImage = Image.FromFile(ofd.FileName))
                {
                    pictureBox4.Image = new Bitmap(tempImage); // Clone to free the file
                }
            }
            Clone();
        }
        public void Clone() 
        {
            if (pictureBox4.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // Use Format.Png to avoid RawFormat errors
                    pictureBox4.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    profileImage = ms.ToArray();
                    
                }
            }

        }
       



        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pictureBox4.Width, pictureBox4.Height);
            pictureBox4.Region = new Region(path);
        }
    } 
}
