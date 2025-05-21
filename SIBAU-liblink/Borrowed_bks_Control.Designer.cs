namespace SIBAU_liblink
{
    partial class Borrowed_bks_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borrowed_bks_Control));
            label3 = new Label();
            DTP2 = new DateTimePicker();
            label4 = new Label();
            comboBox1 = new ComboBox();
            panel_top = new Panel();
            label1 = new Label();
            DTP1 = new DateTimePicker();
            pictureBox2 = new PictureBox();
            textBox2 = new TextBox();
            label6 = new Label();
            pictureBox8 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            label5 = new Label();
            DGV_bbk = new DataGridView();
            panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_bbk).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(402, 101);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 98;
            label3.Text = "From:";
            // 
            // DTP2
            // 
            DTP2.Location = new Point(680, 97);
            DTP2.Name = "DTP2";
            DTP2.Size = new Size(200, 23);
            DTP2.TabIndex = 101;
            DTP2.KeyDown += DTP2_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(653, 101);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 100;
            label4.Text = "To:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Returned Books", "Borrowed Books " });
            comboBox1.Location = new Point(198, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(201, 23);
            comboBox1.TabIndex = 103;
            comboBox1.KeyDown += comboBox1_KeyDown;
            // 
            // panel_top
            // 
            panel_top.Controls.Add(label1);
            panel_top.Controls.Add(DTP1);
            panel_top.Controls.Add(label3);
            panel_top.Controls.Add(pictureBox2);
            panel_top.Controls.Add(label4);
            panel_top.Controls.Add(textBox2);
            panel_top.Controls.Add(DTP2);
            panel_top.Controls.Add(label6);
            panel_top.Controls.Add(pictureBox8);
            panel_top.Controls.Add(comboBox1);
            panel_top.Dock = DockStyle.Top;
            panel_top.Location = new Point(0, 0);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(884, 128);
            panel_top.TabIndex = 107;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(147, 101);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 111;
            label1.Text = "status:";
            // 
            // DTP1
            // 
            DTP1.Location = new Point(447, 97);
            DTP1.Name = "DTP1";
            DTP1.Size = new Size(200, 23);
            DTP1.TabIndex = 110;
            DTP1.KeyDown += DTP1_KeyDown;
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
            label6.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(339, 6);
            label6.Name = "label6";
            label6.Size = new Size(275, 37);
            label6.TabIndex = 93;
            label6.Text = "Borrowed Books";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(4, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(140, 92);
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
            label2.Location = new Point(502, 11);
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
            label5.Size = new Size(137, 24);
            label5.TabIndex = 99;
            label5.Text = "Total Books:";
            // 
            // DGV_bbk
            // 
            DGV_bbk.BackgroundColor = Color.White;
            DGV_bbk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_bbk.Dock = DockStyle.Fill;
            DGV_bbk.Location = new Point(0, 128);
            DGV_bbk.Name = "DGV_bbk";
            DGV_bbk.Size = new Size(884, 341);
            DGV_bbk.TabIndex = 109;
            // 
            // Borrowed_bks_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(DGV_bbk);
            Controls.Add(panel1);
            Controls.Add(panel_top);
            Name = "Borrowed_bks_Control";
            Size = new Size(884, 516);
            panel_top.ResumeLayout(false);
            panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_bbk).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private DateTimePicker DTP2;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private Panel panel_top;
        private PictureBox pictureBox2;
        private TextBox textBox2;
        private Label label6;
        private PictureBox pictureBox8;
        private DateTimePicker DTP1;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private DataGridView DGV_bbk;
    }
}
