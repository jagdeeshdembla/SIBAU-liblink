namespace SIBAU_liblink
{
    partial class Report_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report_Control));
            panel_top = new Panel();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            btn_eel = new Button();
            btn_prt = new Button();
            btn_epdf = new Button();
            DGV_rpt = new DataGridView();
            panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_rpt).BeginInit();
            SuspendLayout();
            // 
            // panel_top
            // 
            panel_top.Controls.Add(dateTimePicker2);
            panel_top.Controls.Add(label4);
            panel_top.Controls.Add(pictureBox5);
            panel_top.Controls.Add(label3);
            panel_top.Controls.Add(dateTimePicker1);
            panel_top.Controls.Add(pictureBox2);
            panel_top.Controls.Add(label5);
            panel_top.Controls.Add(textBox2);
            panel_top.Controls.Add(pictureBox1);
            panel_top.Controls.Add(comboBox1);
            panel_top.Controls.Add(label6);
            panel_top.Controls.Add(textBox1);
            panel_top.Dock = DockStyle.Top;
            panel_top.Location = new Point(0, 0);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(884, 100);
            panel_top.TabIndex = 108;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(679, 71);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 101;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(648, 75);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 100;
            label4.Text = "To:";
            label4.Click += label4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(4, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(120, 92);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 108;
            pictureBox5.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(394, 74);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 98;
            label3.Text = "From:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(443, 70);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 99;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2213, 78);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 18);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 95;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(132, 74);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 102;
            label5.Text = "Status:";
            label5.Click += label5_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox2.BackColor = Color.White;
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(1959, 76);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Search Book";
            textBox2.Size = new Size(287, 23);
            textBox2.TabIndex = 94;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1268, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 17);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 105;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All", "Issued Books", "Returned Books", "Overdue Books", "Student Wise", "Monthly Report" });
            comboBox1.Location = new Point(189, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(201, 23);
            comboBox1.TabIndex = 103;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(362, 6);
            label6.Name = "label6";
            label6.Size = new Size(198, 37);
            label6.TabIndex = 93;
            label6.Text = "LMS Report";
            label6.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(1099, 87);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search Book or Student";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 95;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_eel);
            panel1.Controls.Add(btn_prt);
            panel1.Controls.Add(btn_epdf);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 473);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 43);
            panel1.TabIndex = 109;
            // 
            // btn_eel
            // 
            btn_eel.BackColor = Color.Blue;
            btn_eel.Cursor = Cursors.Hand;
            btn_eel.FlatAppearance.BorderSize = 0;
            btn_eel.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_eel.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_eel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_eel.ForeColor = Color.White;
            btn_eel.Location = new Point(361, 4);
            btn_eel.Name = "btn_eel";
            btn_eel.Size = new Size(160, 35);
            btn_eel.TabIndex = 149;
            btn_eel.Text = "Export to Excel";
            btn_eel.UseVisualStyleBackColor = false;
            // 
            // btn_prt
            // 
            btn_prt.BackColor = Color.Red;
            btn_prt.Cursor = Cursors.Hand;
            btn_prt.FlatAppearance.BorderSize = 0;
            btn_prt.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_prt.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_prt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_prt.ForeColor = Color.White;
            btn_prt.Location = new Point(612, 4);
            btn_prt.Name = "btn_prt";
            btn_prt.Size = new Size(160, 35);
            btn_prt.TabIndex = 148;
            btn_prt.Text = "Print";
            btn_prt.UseVisualStyleBackColor = false;
            // 
            // btn_epdf
            // 
            btn_epdf.BackColor = Color.Green;
            btn_epdf.Cursor = Cursors.Hand;
            btn_epdf.FlatAppearance.BorderSize = 0;
            btn_epdf.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_epdf.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_epdf.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_epdf.ForeColor = Color.White;
            btn_epdf.Location = new Point(108, 4);
            btn_epdf.Name = "btn_epdf";
            btn_epdf.Size = new Size(160, 35);
            btn_epdf.TabIndex = 147;
            btn_epdf.Text = "Export to PDF";
            btn_epdf.UseVisualStyleBackColor = false;
            // 
            // DGV_rpt
            // 
            DGV_rpt.BackgroundColor = Color.White;
            DGV_rpt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_rpt.Dock = DockStyle.Fill;
            DGV_rpt.Location = new Point(0, 100);
            DGV_rpt.Name = "DGV_rpt";
            DGV_rpt.Size = new Size(884, 373);
            DGV_rpt.TabIndex = 110;
            // 
            // Report_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(DGV_rpt);
            Controls.Add(panel1);
            Controls.Add(panel_top);
            Name = "Report_Control";
            Size = new Size(884, 516);
            panel_top.ResumeLayout(false);
            panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_rpt).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_top;
        private PictureBox pictureBox2;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker2;
        private PictureBox pictureBox5;
        private Panel panel1;
        private DataGridView DGV_rpt;
        private Button btn_prt;
        private Button btn_epdf;
        private Button btn_eel;
    }
}
