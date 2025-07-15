namespace SIBAU_liblink
{
    partial class Search_bks_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_bks_Control));
            panel_top = new Panel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            pictureBox8 = new PictureBox();
            DGV_sbk = new DataGridView();
            panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_sbk).BeginInit();
            SuspendLayout();
            // 
            // panel_top
            // 
            panel_top.Controls.Add(pictureBox1);
            panel_top.Controls.Add(textBox1);
            panel_top.Controls.Add(label2);
            panel_top.Controls.Add(label3);
            panel_top.Controls.Add(pictureBox8);
            panel_top.Dock = DockStyle.Top;
            panel_top.Location = new Point(0, 0);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(884, 78);
            panel_top.TabIndex = 96;
            panel_top.Paint += panel_top_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(845, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 101;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(628, 50);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(250, 23);
            textBox1.TabIndex = 100;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(567, 55);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 98;
            label2.Text = "Search:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(343, 6);
            label3.Name = "label3";
            label3.Size = new Size(173, 28);
            label3.TabIndex = 93;
            label3.Text = "Search Books";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(4, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(100, 70);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 92;
            pictureBox8.TabStop = false;
            // 
            // DGV_sbk
            // 
            DGV_sbk.BackgroundColor = Color.White;
            DGV_sbk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_sbk.Dock = DockStyle.Fill;
            DGV_sbk.Location = new Point(0, 78);
            DGV_sbk.Name = "DGV_sbk";
            DGV_sbk.Size = new Size(884, 438);
            DGV_sbk.TabIndex = 97;
            // 
            // Search_bks_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(DGV_sbk);
            Controls.Add(panel_top);
            Name = "Search_bks_Control";
            Size = new Size(884, 516);
            panel_top.ResumeLayout(false);
            panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_sbk).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_top;
        private PictureBox pictureBox8;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private DataGridView DGV_sbk;
    }
}
