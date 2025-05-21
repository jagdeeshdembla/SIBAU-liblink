using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SIBAU_liblink
{
    public partial class Issue_bks_Control : UserControl
    {
        public Issue_bks_Control()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void Issue_bks_Control_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void ClearFields()
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox5.Clear();
            DTP1.Value = DateTime.Today;
            DTP2.Value = DateTime.Today;
        }

        private void btn_isb_Click(object sender, EventArgs e)
        {
            string insertQuery = @"INSERT INTO IssuedBooks(StudentID, StudentName, Department, Semester, BookID, BookName, IssueDate, DueDate)
                               VALUES 
                               (@StudentID, @StudentName, @Department, @Semester, @BookID, @BookName, @IssueDate, @DueDate);
                               SELECT SCOPE_IDENTITY();";
            string checkBookQuery = "SELECT COUNT(*) FROM Books WHERE BookID = @BookID AND BookName = @BookName AND Quantity > 0";
            string updateBookQty = "UPDATE Books SET Quantity = Quantity - 1 WHERE BookID = @BookID AND BookName = @BookName";
            String dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            SqlConnection con = new SqlConnection(dcon);
            SqlCommand checkCmd = new SqlCommand(checkBookQuery, con);
            checkCmd.Parameters.AddWithValue("@BookID", textBox6.Text);
            checkCmd.Parameters.AddWithValue("@BookName",textBox5.Text);

            con.Open();
            int bookCount = (int)checkCmd.ExecuteScalar();

            if (bookCount == 0)
            {
                MessageBox.Show("This book is not available in the library or out of stock.");
                con.Close();
                return;
            }
            SqlCommand insertCmd = new SqlCommand(insertQuery, con);
            insertCmd.Parameters.AddWithValue("@StudentID", textBox2.Text);
            insertCmd.Parameters.AddWithValue("@StudentName",textBox3.Text);
            insertCmd.Parameters.AddWithValue("@Department", textBox1.Text);
            insertCmd.Parameters.AddWithValue("@Semester", textBox4.Text);
            insertCmd.Parameters.AddWithValue("@BookID", textBox6.Text);
            insertCmd.Parameters.AddWithValue("@BookName", textBox5.Text);
            insertCmd.Parameters.AddWithValue("@IssueDate", DTP1.Value.Date);
            insertCmd.Parameters.AddWithValue("@DueDate", DTP2.Value.Date);

            int IssueID = Convert.ToInt32(insertCmd.ExecuteScalar());

            SqlCommand updateCmd = new SqlCommand(updateBookQty, con);
            updateCmd.Parameters.AddWithValue("@BookID", textBox6.Text);
            updateCmd.Parameters.AddWithValue("@BookName",textBox5.Text);
            updateCmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Book issued successfully! Issue ID: " + IssueID);
            ClearFields();



        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
