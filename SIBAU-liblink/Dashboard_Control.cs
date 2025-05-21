using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;

namespace SIBAU_liblink
{
    public partial class Dashboard_Control : UserControl
    {
        public Dashboard_Control()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
           // InitializeChart();
              DisplayUsers();
              DisplayBooks();
            //  DisplayTBBooks();
            //  DisplayTRBooks();
            //  UpdateChartWithRealData();
              DisplayStudents();
              DisplayTeachers();
        }

        public static class sessionStoreData
        {
            public static int Members;
            public static int Books;
            public static int Borrowed;
            public static int Returned;
        }

        private void InitializeChart()
        {
            // Clear any existing series and chart areas
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            // Create a new chart area
            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.Interval = 20; // Set Y-axis interval to 20 as shown in your image
            chartArea.AxisY.Maximum = 100; // Set maximum Y value to 100
            chart1.ChartAreas.Add(chartArea);

            // Create a new series for the bar chart
            Series series = new Series("Library Data");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true; // Show values on top of bars
            chart1.Series.Add(series);

            // Set chart appearance
            chart1.BackColor = Color.White;
            chartArea.BackColor = Color.White;
        }

        public void UpdateChartWithRealData()
        {
            // Clear previous data
            chart1.Series["Library Data"].Points.Clear();

            // Add data points for each category
            chart1.Series["Library Data"].Points.AddXY("Total Members", sessionStoreData.Members);
            chart1.Series["Library Data"].Points.AddXY("Total Books", sessionStoreData.Books);
            chart1.Series["Library Data"].Points.AddXY("Borrowed Books", sessionStoreData.Borrowed);
            chart1.Series["Library Data"].Points.AddXY("Returned Books", sessionStoreData.Returned);

            // Set different colors for each bar
            chart1.Series["Library Data"].Points[0].Color = Color.FromArgb(41, 128, 185);   // Blue
            chart1.Series["Library Data"].Points[1].Color = Color.FromArgb(39, 174, 96);   // Green
            chart1.Series["Library Data"].Points[2].Color = Color.FromArgb(243, 156, 18);  // Orange
            chart1.Series["Library Data"].Points[3].Color = Color.FromArgb(231, 76, 60);    // Red

            // Adjust Y-axis maximum dynamically based on highest value
            int maxValue = Math.Max(Math.Max(sessionStoreData.Members, sessionStoreData.Books),
                                  Math.Max(sessionStoreData.Borrowed, sessionStoreData.Returned));
            chart1.ChartAreas[0].AxisY.Maximum = maxValue + (20 - maxValue % 20); // Round up to nearest 20
        }

        public void DisplayUsers()
        {
            string query = "SELECT * FROM UsersInfo WHERE UserType = 'Faculty' OR UserType = 'Student'";
            string dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(dcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                label_tms.Text = dt.Rows.Count.ToString();
                sessionStoreData.Members = dt.Rows.Count;
            }
        }

        public void DisplayBooks()
        {
            string query = "SELECT * FROM Books";
            string dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(dcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                label_tbk.Text = dt.Rows.Count.ToString();
                sessionStoreData.Books = dt.Rows.Count;
            }
        }

        public void DisplayTBBooks()
        {
            string query = "SELECT * FROM IssuedBooks";
            string dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(dcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                label_tbbk.Text = dt.Rows.Count.ToString();
                sessionStoreData.Borrowed = dt.Rows.Count;
            }
        }

        public void DisplayTRBooks()
        {
            string query = "SELECT * FROM ReturnedBooks";
            string dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(dcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                label_trbk.Text = dt.Rows.Count.ToString();
                sessionStoreData.Returned = dt.Rows.Count;
            }
        }

        public void DisplayStudents()
        {
            string query = "SELECT * FROM UsersInfo WHERE UserType = 'Student'";
            string dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(dcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                label_tsts.Text = dt.Rows.Count.ToString();
                
            }
        }

        public void DisplayTeachers()
        {
            string query = "SELECT * FROM UsersInfo WHERE UserType = 'Faculty'";
            string dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(dcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                label_ttcs.Text = dt.Rows.Count.ToString();

            }
        }


    }
}