using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data.SqlClient;

namespace SIBAU_liblink
{
    public partial class Manage_acts : UserControl
    {
        public Manage_acts()
        {
            InitializeComponent();
            loadData();
            DGV_MACTS.CellMouseClick += DGV_Users_CellMouseClick;


        }
        private void DGV_Users_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || DGV_MACTS.Columns[e.ColumnIndex].Name != "Action")
                return;

            Rectangle cellBounds = DGV_MACTS.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
            Point mouse = DGV_MACTS.PointToClient(Cursor.Position);

            int btnWidth = 60, spacing = 5, btnHeight = cellBounds.Height - 8;
            Rectangle btnBlock = new Rectangle(cellBounds.Left + spacing, cellBounds.Top + 4, btnWidth, btnHeight);
            Rectangle btnUnblock = new Rectangle(btnBlock.Right + spacing, cellBounds.Top + 4, btnWidth, btnHeight);
            Rectangle btnDelete = new Rectangle(btnUnblock.Right + spacing, cellBounds.Top + 4, btnWidth, btnHeight);

            string userId = DGV_MACTS.Rows[e.RowIndex].Cells["UserID"].Value.ToString();

            if (btnBlock.Contains(mouse))
            {
                UpdateStatus(userId, "Inactive");
            }
            else if (btnUnblock.Contains(mouse))
            {
                UpdateStatus(userId, "Active");
            }
            else if (btnDelete.Contains(mouse))
            {
                DialogResult result = MessageBox.Show("Are you sure to delete this account?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DeleteUser(userId);
                }
            }
            loadData();
        }
        private void DeleteUser(string userId)
        {
            string conStr = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                string query = "DELETE FROM UserInfo WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void UpdateStatus(string userId, string status)
        {
            string conStr = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                string query = "UPDATE UserInfo SET Status = @Status WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        public void loadData()
        {
            string query = "SELECT UserID,FullName,Department,UserType,Status FROM UserInfo WHERE UserType = 'Student' OR UserType = 'Faculty'OR UserType = 'Staff'";
            string dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            SqlConnection con = new SqlConnection(dcon);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGV_MACTS.DataSource = dt;
            con.Close();
            DGV_MACTS.ReadOnly = true;
            DGV_MACTS.AllowUserToAddRows = false;
            DGV_MACTS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_MACTS.MultiSelect = false;
            DGV_MACTS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_MACTS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
           
            DGV_MACTS.ScrollBars = ScrollBars.Both;




            DGV_MACTS.DefaultCellStyle.ForeColor = Color.Black;
            DGV_MACTS.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            DGV_MACTS.EnableHeadersVisualStyles = false;
            DGV_MACTS.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGV_MACTS.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            DGV_MACTS.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            if (!DGV_MACTS.Columns.Contains("Action"))
            {
                DataGridViewColumn actionCol = new DataGridViewTextBoxColumn();
                actionCol.Name = "Action";
                actionCol.HeaderText = "Action";
                actionCol.Width = 150;
                DGV_MACTS.Columns.Add(actionCol);
            }

            // Prevent empty row if no data
            DGV_MACTS.AllowUserToAddRows = false;

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


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void DGV_MACTS_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || DGV_MACTS.Columns[e.ColumnIndex].Name != "Action")
                return;

            e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border);

            int btnWidth = 55;
            int spacing = 5;
            int btnHeight = e.CellBounds.Height - 8;

            Rectangle btnBlock = new Rectangle(e.CellBounds.Left + spacing, e.CellBounds.Top + 4, btnWidth, btnHeight);
            Rectangle btnUnblock = new Rectangle(btnBlock.Right + spacing, e.CellBounds.Top + 4, btnWidth, btnHeight);
            Rectangle btnDelete = new Rectangle(btnUnblock.Right + spacing, e.CellBounds.Top + 4, btnWidth, btnHeight);

            Font btnFont = new Font("Segoe UI", 8, FontStyle.Bold);

            // 🟩 Block = Green
            DrawCustomButton(e.Graphics, btnBlock, "Block", Color.Green, Color.White, btnFont);
            // 🟨 Unblock = Yellow
            DrawCustomButton(e.Graphics, btnUnblock, "Unblock", Color.Blue, Color.White, btnFont);
            // 🟥 Delete = Red
            DrawCustomButton(e.Graphics, btnDelete, "Delete", Color.Red, Color.White, btnFont);

            e.Handled = true;

        }

        private void DGV_MACTS_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || DGV_MACTS.Columns[e.ColumnIndex].Name != "Action")
            {
                DGV_MACTS.Cursor = Cursors.Default;
                return;
            }

            int btnWidth = 60;
            int spacing = 5;
            int btnHeight = DGV_MACTS.Rows[e.RowIndex].Cells[e.ColumnIndex].Size.Height - 8;

            Rectangle cellBounds = DGV_MACTS.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
            Rectangle btnBlock = new Rectangle(cellBounds.Left + spacing, cellBounds.Top + 4, btnWidth, btnHeight);
            Rectangle btnUnblock = new Rectangle(btnBlock.Right + spacing, cellBounds.Top + 4, btnWidth, btnHeight);
            Rectangle btnDelete = new Rectangle(btnUnblock.Right + spacing, cellBounds.Top + 4, btnWidth, btnHeight);

            Point mousePosition = DGV_MACTS.PointToClient(Cursor.Position);

            if (btnBlock.Contains(mousePosition) || btnUnblock.Contains(mousePosition) || btnDelete.Contains(mousePosition))
            {
                DGV_MACTS.Cursor = Cursors.Hand;
            }
            else
            {
                DGV_MACTS.Cursor = Cursors.Default;
            }
        }
    }
}
