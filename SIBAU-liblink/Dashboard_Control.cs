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
            
            DisplayMembers();
            DisplayStudents();
            DisplayFaculty();
            DisplayStaff();

            DisplayBooks();
            DisplayTIBooks();

            //  DisplayTBBooks();
            //  DisplayTRBooks();



              LoadLibraryReport();
        }
        
        public static class sessionStoreData
        {
            public static int Members;
            public static int Books;
            public static int Borrowed;
            public static int Returned;
        }
        public void LoadLibraryReport()
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Legends.Clear();
            chart1.Titles.Clear();

            // Step 1: Setup chart area
            ChartArea chartArea = new ChartArea("MainArea");
            chartArea.AxisX.Interval = 1; // Ensure all labels show
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisX.Title = "Categories";
            chartArea.AxisY.Title = "Total Count";
            chartArea.AxisX.LabelStyle.Angle = 0;
            chartArea.AxisX.IsLabelAutoFit = true;
            chart1.ChartAreas.Add(chartArea);

            // Step 2: Create ONE series for all categories
            Series series = new Series("Library Report");
            series.ChartType = SeriesChartType.Column;
            series.XValueType = ChartValueType.String;

            // Step 3: Add each value with its own X-axis label (category)
            series.Points.AddXY("Members", sessionStoreData.Members);
            series.Points.AddXY("Books", sessionStoreData.Books);
            series.Points.AddXY("Issued", sessionStoreData.Borrowed);
            series.Points.AddXY("Returned", sessionStoreData.Returned);

            // Step 4: Show values on columns
            series.IsValueShownAsLabel = true;
            series.LabelForeColor = Color.Black;
            series.Color = Color.DodgerBlue;

            chart1.Series.Add(series);

            // Optional: Add title
            chart1.Titles.Add("Library Report Overview");
        }



        public void DisplayMembers()
        {
            string query = "SELECT * FROM UserInfo WHERE UserType = 'Faculty' OR UserType = 'Student' OR UserType = 'Staff'";
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
        public void DisplayStudents()
        {
            string query = "SELECT * FROM UserInfo WHERE UserType = 'Student'";
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
        public void DisplayFaculty()
        {
            string query = "SELECT * FROM UserInfo WHERE UserType = 'Faculty'";
            string dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(dcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                label_tfts.Text = dt.Rows.Count.ToString();

            }
        }

        public void DisplayStaff() 
        {
            string query = "SELECT * FROM UserInfo WHERE UserType = 'Staff'";
            string dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(dcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                label_tsfs.Text = dt.Rows.Count.ToString();

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
                label_tbks.Text = dt.Rows.Count.ToString();
                sessionStoreData.Books = dt.Rows.Count;
            }
        }

        public void DisplayTIBooks()
        {
            string query = "SELECT * FROM IssueBooks";
            string dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(dcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                label_tibk.Text = dt.Rows.Count.ToString();
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

        
        


    }
}