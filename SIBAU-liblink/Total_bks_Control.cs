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
    public partial class Total_bks_Control : UserControl
    {
        public Total_bks_Control()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

           

            InfoBooks();
        }

        

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void InfoBooks() {
            string query = "SELECT BookID,BookName,AuthorName,Publisher,Category,ISBN,Quantity,Price FROM Books";
            String dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            SqlConnection con = new SqlConnection(dcon);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DGV_tbk.DataSource = dt;
            label4.Text = dt.Rows.Count.ToString();
            


            DGV_tbk.ReadOnly = true;
            DGV_tbk.AllowUserToAddRows = false;
            DGV_tbk.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_tbk.MultiSelect = false;
            DGV_tbk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_tbk.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_tbk.ScrollBars = ScrollBars.Both;



            DGV_tbk.DefaultCellStyle.ForeColor = Color.Black;
            DGV_tbk.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            DGV_tbk.EnableHeadersVisualStyles = false;
            DGV_tbk.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGV_tbk.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            DGV_tbk.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);




        }
    }
}
