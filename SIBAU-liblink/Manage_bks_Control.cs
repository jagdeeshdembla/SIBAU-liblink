using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
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
            loadData();
            DGV_MBKS.CellMouseClick += DGV_MBKS_CellMouseClick;

        }
        private void DGV_MBKS_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || DGV_MBKS.Columns[e.ColumnIndex].Name != "Action")
                return;

            // Get clicked cell bounds
            Rectangle cellBounds = DGV_MBKS.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
            int btnWidth = 60;
            int spacing = 2;
            int btnHeight = cellBounds.Height - 8;

            Rectangle btnEdit = new Rectangle(cellBounds.Left + spacing, cellBounds.Top + 4, btnWidth, btnHeight);
            Rectangle btnDelete = new Rectangle(btnEdit.Right + spacing * 2 + btnWidth, cellBounds.Top + 4, btnWidth, btnHeight);

            // Detect which button was clicked
            Point clickPoint = DGV_MBKS.PointToClient(Cursor.Position);

            // Get BookID of the clicked row
            string bookId = DGV_MBKS.Rows[e.RowIndex].Cells["BookID"].Value.ToString();

            if (btnEdit.Contains(clickPoint))
            {
                // 🟩 Edit Action
                EditBook(bookId);
            }
            else if (btnDelete.Contains(clickPoint))
            {
                // 🟥 Delete Action
                DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DeleteBook(bookId);
                    loadData(); // Refresh grid
                }
            }
        }


        private void DeleteBook(string bookId)
        {
            string dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(dcon))
            {
                con.Open();
                string query = "DELETE FROM Books WHERE BookID = @BookID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@BookID", bookId);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void EditBook(string bookId)
        {
           
           Edit_book edit = new Edit_book(this,bookId);
             edit.Show();
            
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            Add_books add = new Add_books(this);
            add.Show();
            loadData();
        }
        public void loadData()
        {
            string query = @"SELECT BookID,BookName,Category,Quantity AS Availability FROM Books";
            string dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            SqlConnection con = new SqlConnection(dcon);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGV_MBKS.DataSource = dt;
            con.Close();
            DGV_MBKS.ReadOnly = true;
            DGV_MBKS.AllowUserToAddRows = false;
            DGV_MBKS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_MBKS.MultiSelect = false;
            DGV_MBKS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_MBKS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_MBKS.ScrollBars = ScrollBars.Both;



            DGV_MBKS.DefaultCellStyle.ForeColor = Color.Black;
            DGV_MBKS.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            DGV_MBKS.EnableHeadersVisualStyles = false;
            DGV_MBKS.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGV_MBKS.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            DGV_MBKS.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            if (!DGV_MBKS.Columns.Contains("Action"))
            {
                DataGridViewColumn actionCol = new DataGridViewTextBoxColumn();
                actionCol.Name = "Action";
                actionCol.HeaderText = "Action";
                actionCol.Width = 150;
                DGV_MBKS.Columns.Add(actionCol);
            }

            // Prevent empty row if no data
            DGV_MBKS.AllowUserToAddRows = false;

        }

        private void DGV_MBKS_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || DGV_MBKS.Columns[e.ColumnIndex].Name != "Action")
                return;

            e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border);

            int btnWidth = 60;
            int spacing = 2;
            int btnHeight = e.CellBounds.Height - 8;

            Rectangle btnBlock = new Rectangle(e.CellBounds.Left + spacing, e.CellBounds.Top + 4, btnWidth, btnHeight);
            Rectangle btnUnblock = new Rectangle(btnBlock.Right + spacing, e.CellBounds.Top + 4, btnWidth, btnHeight);
            Rectangle btnDelete = new Rectangle(btnUnblock.Right + spacing, e.CellBounds.Top + 4, btnWidth, btnHeight);

            Font btnFont = new Font("Segoe UI", 8, FontStyle.Bold);

            // 🟩 Block = Green
            DrawCustomButton(e.Graphics, btnBlock, "Edit", Color.Green, Color.White, btnFont);


            // 🟥 Delete = Red
            DrawCustomButton(e.Graphics, btnDelete, "Delete", Color.Red, Color.White, btnFont);

            e.Handled = true;
        }
        private void DrawCustomButton(Graphics g, Rectangle bounds, string text, Color backColor, Color foreColor, Font font)
        {
            using (SolidBrush backBrush = new SolidBrush(backColor))
            using (SolidBrush textBrush = new SolidBrush(foreColor))
            using (Pen borderPen = new Pen(Color.Black))
            {
                g.FillRectangle(backBrush, bounds);
                g.DrawRectangle(borderPen, bounds);

                StringFormat sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                g.DrawString(text, font, textBrush, bounds, sf);
            }
        }

        private void DGV_MBKS_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || DGV_MBKS.Columns[e.ColumnIndex].Name != "Action")
            {
                DGV_MBKS.Cursor = Cursors.Default;
                return;
            }

            int btnWidth = 60;
            int spacing = 5;
            int btnHeight = DGV_MBKS.Rows[e.RowIndex].Cells[e.ColumnIndex].Size.Height - 8;

            Rectangle cellBounds = DGV_MBKS.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
            Rectangle btnBlock = new Rectangle(cellBounds.Left + spacing, cellBounds.Top + 4, btnWidth, btnHeight);
            Rectangle btnUnblock = new Rectangle(btnBlock.Right + spacing, cellBounds.Top + 4, btnWidth, btnHeight);
            Rectangle btnDelete = new Rectangle(btnUnblock.Right + spacing, cellBounds.Top + 4, btnWidth, btnHeight);

            Point mousePosition = DGV_MBKS.PointToClient(Cursor.Position);

            if (btnBlock.Contains(mousePosition) || btnUnblock.Contains(mousePosition) || btnDelete.Contains(mousePosition))
            {
                DGV_MBKS.Cursor = Cursors.Hand;
            }
            else
            {
                DGV_MBKS.Cursor = Cursors.Default;
            }
        }
    }
}
