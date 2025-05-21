using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            DGV_rpt.Columns.Add("Title", "Book Title");
            DGV_rpt.Columns.Add("S_ID", "Student ID");
            DGV_rpt.Columns.Add("Status", "Status");
            DGV_rpt.Columns.Add("I_Date", "Issue Date");
            DGV_rpt.Columns.Add("Category", "Category");
            DGV_rpt.Columns.Add("R_Date", "Return Date");
            DGV_rpt.Columns.Add("D_Date", "Due Date");
            DGV_rpt.Columns.Add("Fine", "Fine");

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
