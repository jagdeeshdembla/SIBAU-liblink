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
    public partial class Return_bks_stu_Control : UserControl
    {
        public Return_bks_stu_Control()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
          //  returnedBook();
        }
        private void returnedBook()
        {
            string query = @"SELECT BookID, BookName, ReturnDate,DueDate,Fine  FROM returnedBooks WHERE StudentID = @id";
            string dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            SqlConnection con = new SqlConnection(dcon);
            SqlDataAdapter adpt = new SqlDataAdapter(query, con);
            con.Open();
            adpt.SelectCommand.Parameters.AddWithValue("@id", sessionData.UserID);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DGV_rbk.DataSource = dt;
            label3.Text = dt.Rows.Count.ToString();
            con.Close();

            DGV_rbk.ReadOnly = true;
            DGV_rbk.AllowUserToAddRows = false;
            DGV_rbk.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_rbk.MultiSelect = false;
            DGV_rbk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_rbk.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_rbk.ScrollBars = ScrollBars.Both;

            DGV_rbk.DefaultCellStyle.ForeColor = Color.Black;
            DGV_rbk.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            DGV_rbk.EnableHeadersVisualStyles = false;
            DGV_rbk.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGV_rbk.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            DGV_rbk.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }
    }
}
