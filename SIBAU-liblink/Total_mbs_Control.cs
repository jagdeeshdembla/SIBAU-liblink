using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIBAU_liblink
{
    public partial class Total_mbs_Control : UserControl
    {
        public Total_mbs_Control()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            UserInfo();



        }

        
        

        private void UserInfo()
        {
    
           string query = "SELECT ID,FullName Email,Department, UserType, Gender FROM UsersInfo WHERE UserType = 'Student' OR UserType = 'Faculty'";
           string dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            SqlConnection con = new SqlConnection(dcon);
            con.Open();
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataAdapter da = new SqlDataAdapter(cmd); 
            DataTable dt = new DataTable(); 
            da.Fill(dt);
            DGV_tms.DataSource = dt;    
            con.Close();
            label4.Text = dt.Rows.Count.ToString();
             
                

                        // DataGridView Styling
           DGV_tms.ReadOnly = true;
           DGV_tms.AllowUserToAddRows = false;
           DGV_tms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           DGV_tms.MultiSelect = false;
           DGV_tms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           DGV_tms.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
           DGV_tms.ScrollBars = ScrollBars.Both;
           


           DGV_tms.DefaultCellStyle.ForeColor = Color.Black;
           DGV_tms.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
           DGV_tms.EnableHeadersVisualStyles = false;
           DGV_tms.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
           DGV_tms.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
           DGV_tms.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    



        }
    }
}
