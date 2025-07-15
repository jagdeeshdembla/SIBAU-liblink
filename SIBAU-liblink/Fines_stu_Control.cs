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
    public partial class Fines_stu_Control : UserControl
    {
        public Fines_stu_Control()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            //DisplayFines();
        }

        public void DisplayFines()
        {
            string query = @"SELECT BookID,BookName,ReturnDate,DueDate,Fine FROM ReturnedBooks WHERE Fine > 0 AND StudentID = @id";
            string dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            SqlConnection con = new SqlConnection(dcon);
            SqlDataAdapter adpt = new SqlDataAdapter(query, con);
            con.Open();
            adpt.SelectCommand.Parameters.AddWithValue("@id", sessionData.UserID);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DGV_Fines.DataSource = dt; 
            label3.Text = dt.Rows.Count.ToString();
            con.Close();

            DGV_Fines.ReadOnly = true;
            DGV_Fines.AllowUserToAddRows = false;
            DGV_Fines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Fines.MultiSelect = false;
            DGV_Fines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Fines.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_Fines.ScrollBars = ScrollBars.Both;



            DGV_Fines.DefaultCellStyle.ForeColor = Color.Black;
            DGV_Fines.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            DGV_Fines.EnableHeadersVisualStyles = false;
            DGV_Fines.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGV_Fines.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            DGV_Fines.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }
    }
}
