namespace SIBAU_liblink
{
    partial class Manage_bks_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_bks_Control));
            label3 = new Label();
            btn_add = new Button();
            pictureBox8 = new PictureBox();
            panel1 = new Panel();
            DGV_MBKS = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_MBKS).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(377, 6);
            label3.Name = "label3";
            label3.Size = new Size(181, 28);
            label3.TabIndex = 68;
            label3.Text = "Manage Books";
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
            btn_add.Location = new Point(776, 40);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(102, 34);
            btn_add.TabIndex = 87;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(4, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(100, 70);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 91;
            pictureBox8.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btn_add);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 78);
            panel1.TabIndex = 92;
            // 
            // DGV_MBKS
            // 
            DGV_MBKS.BackgroundColor = Color.White;
            DGV_MBKS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_MBKS.Dock = DockStyle.Fill;
            DGV_MBKS.Location = new Point(0, 78);
            DGV_MBKS.Name = "DGV_MBKS";
            DGV_MBKS.Size = new Size(884, 438);
            DGV_MBKS.TabIndex = 93;
            DGV_MBKS.CellMouseMove += DGV_MBKS_CellMouseMove;
            DGV_MBKS.CellPainting += DGV_MBKS_CellPainting;
            // 
            // Manage_bks_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(DGV_MBKS);
            Controls.Add(panel1);
            Name = "Manage_bks_Control";
            Size = new Size(884, 516);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_MBKS).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private Button btn_add;
        private PictureBox pictureBox8;
        private Panel panel1;
        private DataGridView DGV_MBKS;
    }
}
