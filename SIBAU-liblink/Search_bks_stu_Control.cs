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
    public partial class Search_bks_stu_Control : UserControl
    {
        public Search_bks_stu_Control()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;


        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchBook();
            }
        }
        private void SearchBook()
        {
            string query = @"SELECT BookID,BookName,Category,Quantity AS Availability FROM Books WHERE 
                           BookName LIKE @Search OR Category LIKE @Search OR CAST(BookID AS NVARCHAR) LIKE @Search";
            string dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            SqlConnection con = new SqlConnection(dcon);
            SqlCommand cmd = new SqlCommand(query, con);
            string searchText = "%" + textBox1.Text.Trim() + "%";
            cmd.Parameters.AddWithValue("@Search", searchText);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGV_sbk.DataSource = dt;

            DGV_sbk.ReadOnly = true;
            DGV_sbk.AllowUserToAddRows = false;
            DGV_sbk.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_sbk.MultiSelect = false;
            DGV_sbk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_sbk.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_sbk.ScrollBars = ScrollBars.Both;

            DGV_sbk.DefaultCellStyle.ForeColor = Color.Black;
            DGV_sbk.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            DGV_sbk.EnableHeadersVisualStyles = false;
            DGV_sbk.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGV_sbk.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            DGV_sbk.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }
    }
}
