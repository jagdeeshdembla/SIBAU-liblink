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

namespace SIBAU_liblink
{
    public partial class Report_Control : UserControl
    {
        public Report_Control()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            DGV_rpt.Columns.Clear();
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
            DGV_rpt.DataSource = dt;
            con.Close();


            DGV_rpt.ReadOnly = true;
            DGV_rpt.AllowUserToAddRows = false;
            DGV_rpt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_rpt.MultiSelect = false;
            DGV_rpt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_rpt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_rpt.ScrollBars = ScrollBars.Both;

            DGV_rpt.DefaultCellStyle.ForeColor = Color.Black;
            DGV_rpt.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            DGV_rpt.EnableHeadersVisualStyles = false;
            DGV_rpt.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGV_rpt.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            DGV_rpt .ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

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
            DGV_rpt.DataSource = dt;
          
            con.Close();


            DGV_rpt.ReadOnly = true;
            DGV_rpt.AllowUserToAddRows = false;
            DGV_rpt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_rpt.MultiSelect = false;
            DGV_rpt .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_rpt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_rpt.ScrollBars = ScrollBars.Both;

            DGV_rpt.DefaultCellStyle.ForeColor = Color.Black;
            DGV_rpt.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            DGV_rpt.EnableHeadersVisualStyles = false;
            DGV_rpt.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGV_rpt.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            DGV_rpt.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DGV_rpt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
