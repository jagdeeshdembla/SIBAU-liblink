using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace SIBAU_liblink
{
    public partial class Return_bks_Control : UserControl
    {
        public Return_bks_Control()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }


        private void ClearFields()
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox5.Clear();
            comboBox1.SelectedIndex = -1;
            DTP1.Value = DateTime.Today;
            DTP2.Value = DateTime.Today;
        }

        private void btn_rtb_Click(object sender, EventArgs e)
        {
            String dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            SqlConnection con = new SqlConnection(dcon);
            string insertQuery = @"INSERT INTO ReturnedBooks(StudentID, StudentName, Department, Semester, BookID, BookName, ReturnDate, DueDate,Fine)
                               VALUES 
                               (@StudentID, @StudentName, @Department, @Semester, @BookID, @BookName, @ReturnDate, @DueDate,@Fine)";
            string updateBookQty = "UPDATE Books SET Quantity = Quantity + 1 WHERE BookID = @BookID AND BookName = @BookName";
            string deleteQuery = "DELETE FROM IssuedBooks WHERE StudentID = @StudentID AND BookID = @BookID";
            DateTime returnDate = DTP1.Value;
            DateTime dueDate = DTP2.Value;
            int fine = 0;
            if (returnDate > dueDate)
            {
                int daysLate = (returnDate - dueDate).Days;
                fine = daysLate * 10; // Rs.10 per day
            }
            con.Open();
            SqlCommand insertcmd = new SqlCommand(insertQuery, con);
            insertcmd.Parameters.AddWithValue("@StudentID", textBox2.Text);
            insertcmd.Parameters.AddWithValue("@StudentName", textBox3.Text);
            insertcmd.Parameters.AddWithValue("@Department", textBox1.Text);
            insertcmd.Parameters.AddWithValue("@Semester", textBox4.Text);
            insertcmd.Parameters.AddWithValue("@BookID", textBox6.Text);
            insertcmd.Parameters.AddWithValue("@BookName", textBox5.Text);
            insertcmd.Parameters.AddWithValue("@ReturnDate", returnDate);
            insertcmd.Parameters.AddWithValue("@DueDate", dueDate);
            insertcmd.Parameters.AddWithValue("@Fine", fine);

            int ReturnID = Convert.ToInt32(insertcmd.ExecuteScalar());

            SqlCommand updatecmd = new SqlCommand(updateBookQty, con);
            updatecmd.Parameters.AddWithValue("@BookID", textBox6.Text);
            updatecmd.Parameters.AddWithValue("@BookName", textBox5.Text);
            updatecmd.ExecuteNonQuery();

            SqlCommand deletecmd = new SqlCommand(deleteQuery, con);
            deletecmd.Parameters.AddWithValue("@StudentID", textBox2.Text);
            deletecmd.Parameters.AddWithValue("@BookID", textBox6.Text);
            deletecmd.ExecuteNonQuery();

            MessageBox.Show($"Book returned successfully! Return ID:{ReturnID}\nFine: Rs. {fine}", "Success");
            ClearFields();
            con.Close();
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
