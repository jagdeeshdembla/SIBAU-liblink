using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static SIBAU_liblink.Login_Form;
using System.Data.SqlClient;

namespace SIBAU_liblink
{
    public partial class Dashboard_stu_Control: UserControl
    {
        public Dashboard_stu_Control()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
           // StudentBarChart();
            DisplayTBBooks();
            DisplayTRBooks();
          //  DisplayFines();
        }
        private void StudentBarChart()
        {
            // Sample values
            int totalBook = 5;
            int totalReturn = 8;
            int totalFine = 8;
            int dueDays = 7;

            Stu_chart.Series.Clear();
            Stu_chart.Titles.Clear();

            // Set chart title
            Stu_chart.Titles.Add("Library Report");
            Stu_chart.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
            Stu_chart.Titles[0].ForeColor = Color.Black;

            // Create series
            Series series = new Series("Library Data");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            series.LabelForeColor = Color.Black;
            series.BorderColor = Color.Black;
            series.BorderWidth = 3; // Bold border like your image
            series["PointWidth"] = "0.5"; // Add spacing between bars

            // Add data points with custom X-axis labels
            series.Points.AddXY("total book", totalBook);
            series.Points.AddXY("Total Book Return", totalReturn);
            series.Points.AddXY("Fine", totalFine);
            series.Points.AddXY("Due Day", dueDays);

            // Set color of bars (all same or different as per your style)
            foreach (DataPoint point in series.Points)
            {
                point.Color = Color.White; // Fill white like your image
            }

            Stu_chart.Series.Add(series);

            // Customize axis
            var area = Stu_chart.ChartAreas[0];
            area.AxisX.Title = "Report Category";
            area.AxisY.Title = "Count";
            area.AxisX.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
            area.AxisY.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);

            // Axis style
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9);
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9);
            area.AxisX.MajorGrid.LineColor = Color.LightGray;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;

            // Set background to white
            Stu_chart.BackColor = Color.White;
            area.BackColor = Color.White;
        }
        public void DisplayTBBooks() 
        {
            string query = @"SELECT * FROM IssuedBooks WHERE StudentID = @id";
            string dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            SqlConnection con = new SqlConnection(dcon);
            SqlDataAdapter adpt = new SqlDataAdapter(query, con);
            con.Open();
            adpt.SelectCommand.Parameters.AddWithValue("@id", sessionData.UserID);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            label_tbbk.Text = dt.Rows.Count.ToString();
            con.Close();
        }
        public void DisplayTRBooks()
        {
            string query = @"SELECT * FROM ReturnedBooks WHERE StudentID = @id";
            string dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            SqlConnection con = new SqlConnection(dcon);
            SqlDataAdapter adpt = new SqlDataAdapter(query, con);
            con.Open();
            adpt.SelectCommand.Parameters.AddWithValue("@id", sessionData.UserID);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            label_trbk.Text = dt.Rows.Count.ToString();
            con.Close();
        }
        public void DisplayFines() 
        {
            string query = @"SELECT * FROM ReturnedBooks WHERE Fine > 0 AND StudentID = @id";
            string dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            SqlConnection con = new SqlConnection(dcon);
            SqlDataAdapter adpt = new SqlDataAdapter(query, con);
            con.Open();
            adpt.SelectCommand.Parameters.AddWithValue("@id", sessionData.UserID);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            label_otfs.Text = dt.Rows.Count.ToString(); 
            con.Close();

        }
    }
}
