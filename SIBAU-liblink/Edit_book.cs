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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SIBAU_liblink
{
    public partial class Edit_book : Form
    {
        private string bookID;
        Manage_bks_Control manageControl;
        public Edit_book(Manage_bks_Control ctrl, string bookId)
        {
            InitializeComponent();
            this.bookID = bookId;
            manageControl = ctrl;
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            clearfiled();
        }
        public void clearfiled()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            comboBox1.SelectedIndex = -1; // Deselect category
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            String dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            string query = @"UPDATE Books SET BookName = @BookName,AuthorName = @AuthorName,Publisher = @Publisher,
                            Category = @Category,ISBN = @ISBN,Quantity =  @Quantity,Price = @Price WHERE BookID  = @BookID";
            SqlConnection con = new SqlConnection(dcon);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.Parameters.AddWithValue("@BookID",bookID);
            cmd.Parameters.AddWithValue("@BookName", textBox1.Text);
            cmd.Parameters.AddWithValue("@AuthorName", textBox7.Text);
            cmd.Parameters.AddWithValue("@Publisher",textBox2.Text);
            cmd.Parameters.AddWithValue("@Category", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@ISBN", textBox6.Text);
            cmd.Parameters.AddWithValue("@Quantity", textBox4.Text);
            cmd.Parameters.AddWithValue("@Price", decimal.Parse(textBox5.Text));

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Book updated successfully!");
            }
            else
            {
                MessageBox.Show("No book found with that ID.");
            }
            con.Close();
            clearfiled();
            manageControl.loadData();
        }
    }
}
