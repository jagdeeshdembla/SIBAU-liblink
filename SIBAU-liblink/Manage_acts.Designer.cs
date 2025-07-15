namespace SIBAU_liblink
{
    partial class Manage_acts
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_acts));
            btn_add = new Button();
            label3 = new Label();
            pictureBox8 = new PictureBox();
            panel_top = new Panel();
            DGV_MACTS = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_MACTS).BeginInit();
            SuspendLayout();
            // 
            // btn_add
            // 
            btn_add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_add.BackColor = Color.Blue;
            btn_add.Cursor = Cursors.Hand;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_add.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_add.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(780, 42);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(97, 30);
            btn_add.TabIndex = 105;
            btn_add.Text = "Add User";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(355, 6);
            label3.Name = "label3";
            label3.Size = new Size(217, 28);
            label3.TabIndex = 95;
            label3.Text = "Manage Accounts";
            label3.Click += label3_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(4, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(100, 70);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 94;
            pictureBox8.TabStop = false;
            // 
            // panel_top
            // 
            panel_top.Controls.Add(pictureBox8);
            panel_top.Controls.Add(btn_add);
            panel_top.Controls.Add(label3);
            panel_top.Dock = DockStyle.Top;
            panel_top.Location = new Point(0, 0);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(884, 78);
            panel_top.TabIndex = 106;
            // 
            // DGV_MACTS
            // 
            DGV_MACTS.BackgroundColor = Color.White;
            DGV_MACTS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_MACTS.Dock = DockStyle.Fill;
            DGV_MACTS.Location = new Point(0, 78);
            DGV_MACTS.Name = "DGV_MACTS";
            DGV_MACTS.Size = new Size(884, 438);
            DGV_MACTS.TabIndex = 107;
            DGV_MACTS.CellMouseMove += DGV_MACTS_CellMouseMove;
            DGV_MACTS.CellPainting += DGV_MACTS_CellPainting;
            // 
            // Manage_acts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(DGV_MACTS);
            Controls.Add(panel_top);
            Name = "Manage_acts";
            Size = new Size(884, 516);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel_top.ResumeLayout(false);
            panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_MACTS).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private PictureBox pictureBox8;
        private Button btn_add;
        private Panel panel_top;
        private DataGridView DGV_MACTS;
    }
}
