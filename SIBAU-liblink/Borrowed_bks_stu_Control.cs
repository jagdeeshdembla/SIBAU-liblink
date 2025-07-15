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
using static SIBAU_liblink.Login_Form;

namespace SIBAU_liblink
{
    public partial class Borrowed_bks_stu_Control : UserControl
    {
        public Borrowed_bks_stu_Control()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
          // IssuedBook();
        }

        private void IssuedBook()
        {
            string query = @"SELECT BookID, BookName, IssueDate,DueDate  FROM IssuedBooks WHERE StudentID = @id";
            string dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            SqlConnection con = new SqlConnection(dcon);
            SqlDataAdapter adpt = new SqlDataAdapter(query, con);
            con.Open(); 
            adpt.SelectCommand.Parameters.AddWithValue("@id", sessionData.UserID);  
            DataTable dt = new DataTable(); 
            adpt.Fill(dt);
            DGV_bbk.DataSource = dt;
            label3.Text = dt.Rows.Count.ToString();
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
    }
}
