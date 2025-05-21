using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SIBAU_liblink
{
    public partial class Borrowed_bks_Control : UserControl
    {
        public Borrowed_bks_Control()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;




        }
        


        private void DisplayRetuned()
        {
            string query = @"SELECT StudentID, StudentName,Department,Semester, BookID, BookName, ReturnDate,DueDate,Fine
                FROM ReturnedBooks 
                WHERE ReturnDate BETWEEN @FromDate AND @ToDate";
            string dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            SqlConnection con = new SqlConnection(dcon);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.Parameters.AddWithValue("@FromDate", DTP1.Value.Date);
            cmd.Parameters.AddWithValue("@ToDate", DTP2.Value.Date);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DGV_bbk.DataSource = dt;
            label2.Text =  dt.Rows.Count.ToString();
            con.Close();


            DGV_bbk.ReadOnly = true;
            DGV_bbk.AllowUserToAddRows = false;
            DGV_bbk.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_bbk.MultiSelect = false;
            DGV_bbk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_bbk.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_bbk.ScrollBars = ScrollBars.Both;

            DGV_bbk.DefaultCellStyle.ForeColor = Color.Black;
            DGV_bbk.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            DGV_bbk.EnableHeadersVisualStyles = false;
            DGV_bbk.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGV_bbk.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            DGV_bbk.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

        }
        private void DisplayBorrowed()
        {
            string query = @"SELECT StudentID, StudentName,Department,Semester, BookID, BookName, IssueDate,DueDate
                FROM IssuedBooks 
                WHERE IssueDate BETWEEN @FromDate AND @ToDate";

            string dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            SqlConnection con = new SqlConnection(dcon);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.Parameters.AddWithValue("@FromDate", DTP1.Value.Date);
            cmd.Parameters.AddWithValue("@ToDate", DTP2.Value.Date);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DGV_bbk.DataSource = dt;
            label2.Text = dt.Rows.Count.ToString(); 
            con.Close();


            DGV_bbk.ReadOnly = true;
            DGV_bbk.AllowUserToAddRows = false;
            DGV_bbk.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_bbk.MultiSelect = false;
            DGV_bbk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_bbk.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_bbk.ScrollBars = ScrollBars.Both;

            DGV_bbk.DefaultCellStyle.ForeColor = Color.Black;
            DGV_bbk.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            DGV_bbk.EnableHeadersVisualStyles = false;
            DGV_bbk.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGV_bbk.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            DGV_bbk.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

        }


        private void SearchBook()
        {

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a status");
                return;
            }
            if (DTP1.Value > DTP2.Value)
            {
                MessageBox.Show("From Date cannot be later than To Date");
                return;
            }

            string selectedStatus = comboBox1.SelectedItem.ToString().Trim();
            if (selectedStatus == "Returned Books")
            {
                DisplayRetuned();
            }
            else if (selectedStatus == "Borrowed Books")
            {
                DisplayBorrowed();
            }

        }

        private void DTP2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchBook();
            }
        }

        private void DTP1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchBook();
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchBook();
            }
        }
    }
}
