using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SIBAU_liblink
{
    public partial class Manage_bks_Control : UserControl
    {
        public Manage_bks_Control()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Manage_bks_Control_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ClearFields()
        {
            textBox1.Clear();
            textBox7.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox6.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.SelectedIndex = -1; // Unselect the dropdown
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Books 
            (BookID, BookName, AuthorName, Publisher, Category, ISBN, Quantity, Price) 
            VALUES 
            (@BookID, @BookName, @AuthorName, @Publisher, @Category, @ISBN, @Quantity, @Price)";
            String dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            SqlConnection con = new SqlConnection(dcon);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@BookID", textBox1.Text);
            cmd.Parameters.AddWithValue("@BookName", textBox7.Text);
            cmd.Parameters.AddWithValue("@AuthorName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Publisher", textBox3.Text);
            cmd.Parameters.AddWithValue("@Category", comboBox1.Text);
            cmd.Parameters.AddWithValue("@ISBN", textBox6.Text);
            cmd.Parameters.AddWithValue("@Quantity", int.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@Price", decimal.Parse(textBox5.Text));

            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Book added successfully!");
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to add book.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE Books SET BookName = @BookName,AuthorName = @AuthorName,Publisher = @Publisher,
                          Category = @Category,ISBN = @ISBN,Quantity = @Quantity,Price = @Price
                          WHERE BookID = @BookID";
            String dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            SqlConnection con = new SqlConnection(dcon);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@BookID", textBox1.Text);
            cmd.Parameters.AddWithValue("@BookName", textBox7.Text);
            cmd.Parameters.AddWithValue("@AuthorName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Publisher", textBox3.Text);
            cmd.Parameters.AddWithValue("@Category", comboBox1.Text);
            cmd.Parameters.AddWithValue("@ISBN", textBox6.Text);
            cmd.Parameters.AddWithValue("@Quantity", int.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@Price", decimal.Parse(textBox5.Text));
            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Book updated successfully!");
                ClearFields();
            }
            else
            {
                MessageBox.Show("No book found with the given Book ID.");
            }

        }

        private void btn_rmv_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Books WHERE BookID = @BookID";
            String dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            SqlConnection con = new SqlConnection(dcon);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@BookID", textBox1.Text);
            cmd.Parameters.AddWithValue("@BookName", textBox7.Text);
            cmd.Parameters.AddWithValue("@AuthorName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Publisher", textBox3.Text);
            cmd.Parameters.AddWithValue("@Category", comboBox1.Text);
            cmd.Parameters.AddWithValue("@ISBN", textBox6.Text);
            cmd.Parameters.AddWithValue("@Quantity", int.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@Price", decimal.Parse(textBox5.Text));
            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Book deleted successfully!");
                ClearFields();
            }
            else
            {
                MessageBox.Show("No book found with the given Book ID.");
            }
        }
    }
}
