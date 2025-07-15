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
    public partial class Add_books : Form
    {
        Manage_bks_Control manageControl;

        public Add_books(Manage_bks_Control ctrl)
        {
            InitializeComponent();
            manageControl = ctrl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          this.Close();

        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void clearfiled()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.SelectedIndex = -1; // Deselect category
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            clearfiled();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            String dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            string query = @"INSERT INTO Books(BookID,BookName,AuthorName,Publisher,Category,ISBN,Quantity,Price) 
                           VALUES(@BookID, @BookName, @AuthorName, @Publisher, @Category,@ISBN, @Quantity,@Price)";
            SqlConnection con = new SqlConnection(dcon);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.Parameters.AddWithValue("@BookID", textBox1.Text);
            cmd.Parameters.AddWithValue("@BookName", textBox7.Text);
            cmd.Parameters.AddWithValue("@AuthorName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Publisher", textBox3.Text);
            cmd.Parameters.AddWithValue("@Category", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@ISBN",textBox6.Text);
            cmd.Parameters.AddWithValue("@Quantity",textBox4.Text);
            cmd.Parameters.AddWithValue("@Price",decimal.Parse(textBox5.Text));
    
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Book added successfully!");
            }
            else
            {
                MessageBox.Show("Failed to add book.");
            }
            con.Close();
            clearfiled();
            manageControl.loadData();
        }
        
    }
}
