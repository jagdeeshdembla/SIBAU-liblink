namespace SIBAU_liblink
{
    partial class Fines_bks_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fines_bks_Control));
            panel_top = new Panel();
            pictureBox2 = new PictureBox();
            textBox2 = new TextBox();
            label6 = new Label();
            pictureBox8 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            label5 = new Label();
            DGV_Fines = new DataGridView();
            panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Fines).BeginInit();
            SuspendLayout();
            // 
            // panel_top
            // 
            panel_top.Controls.Add(pictureBox2);
            panel_top.Controls.Add(textBox2);
            panel_top.Controls.Add(label6);
            panel_top.Controls.Add(pictureBox8);
            panel_top.Dock = DockStyle.Top;
            panel_top.Location = new Point(0, 0);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(884, 78);
            panel_top.TabIndex = 107;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1529, 78);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 18);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 95;
            pictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox2.BackColor = Color.White;
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(1275, 76);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Search Book";
            textBox2.Size = new Size(287, 23);
            textBox2.TabIndex = 94;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(383, 6);
            label6.Name = "label6";
            label6.Size = new Size(152, 28);
            label6.TabIndex = 93;
            label6.Text = "Fines Books";
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
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 469);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 47);
            panel1.TabIndex = 108;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(495, 11);
            label2.Name = "label2";
            label2.Size = new Size(22, 24);
            label2.TabIndex = 100;
            label2.Text = "0";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(359, 11);
            label5.Name = "label5";
            label5.Size = new Size(128, 24);
            label5.TabIndex = 99;
            label5.Text = "Total Fines:";
            // 
            // DGV_Fines
            // 
            DGV_Fines.BackgroundColor = Color.White;
            DGV_Fines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Fines.Dock = DockStyle.Fill;
            DGV_Fines.Location = new Point(0, 78);
            DGV_Fines.Name = "DGV_Fines";
            DGV_Fines.Size = new Size(884, 391);
            DGV_Fines.TabIndex = 109;
            // 
            // Fines_bks_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(DGV_Fines);
            Controls.Add(panel1);
            Controls.Add(panel_top);
            Name = "Fines_bks_Control";
            Size = new Size(884, 516);
            panel_top.ResumeLayout(false);
            panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Fines).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label5;
        private Panel panel_top;
        private PictureBox pictureBox2;
        private TextBox textBox2;
        private Label label6;
        private PictureBox pictureBox8;
        private Panel panel1;
        private Label label2;
        private DataGridView DGV_Fines;
    }
}
