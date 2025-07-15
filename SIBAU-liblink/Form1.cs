namespace SIBAU_liblink
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private PictureBox pictureBox1;
        private Button btn_lg;
        private Button btn_su;
        private Label label1;



        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            btn_lg = new Button();
            btn_su = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btn_lg
            // 
            btn_lg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_lg.BackColor = Color.White;
            btn_lg.Cursor = Cursors.Hand;
            btn_lg.FlatAppearance.BorderSize = 0;
            btn_lg.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_lg.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_lg.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_lg.Location = new Point(899, 1);
            btn_lg.Name = "btn_lg";
            btn_lg.Size = new Size(89, 34);
            btn_lg.TabIndex = 3;
            btn_lg.Text = "Login";
            btn_lg.UseVisualStyleBackColor = false;
            btn_lg.Click += btn_lg_Click;
            btn_lg.MouseEnter += btn_lg_MouseEnter;
            btn_lg.MouseLeave += btn_lg_MouseLeave;
            // 
            // btn_su
            // 
            btn_su.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_su.BackColor = Color.White;
            btn_su.Cursor = Cursors.Hand;
            btn_su.FlatAppearance.BorderSize = 0;
            btn_su.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_su.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_su.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_su.Location = new Point(992, 1);
            btn_su.Name = "btn_su";
            btn_su.Size = new Size(89, 34);
            btn_su.TabIndex = 4;
            btn_su.Text = "Sign Up";
            btn_su.UseVisualStyleBackColor = false;
            btn_su.Click += btn_su_Click;
            btn_su.MouseEnter += btn_su_MouseEnter;
            btn_su.MouseLeave += btn_su_MouseLeave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(248, 261);
            label1.Name = "label1";
            label1.Size = new Size(555, 44);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO SIBAU-KK LMS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 514);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 47);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Viner Hand ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(207, 4);
            label2.Name = "label2";
            label2.Size = new Size(612, 39);
            label2.TabIndex = 0;
            label2.Text = "\"Developed By : Vandna Jeswani and Jagdeesh Dembla\" ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1084, 561);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btn_su);
            Controls.Add(btn_lg);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Digital Library Management System ";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void btn_lg_Click(object sender, EventArgs e)
        {
            Login_Form login = new Login_Form();
            login.Show();
            Form1 f1 = new Form1();
            f1.Hide();

        }

        private void btn_su_Click(object sender, EventArgs e)
        {
            Registration_Form register = new Registration_Form();
            register.Show();
            Form1 f1 = new Form1();
            f1.Hide();
        }

        private void btn_lg_MouseEnter(object sender, EventArgs e)
        {
            this.btn_lg.ForeColor = Color.Navy;
        }

        private void btn_lg_MouseLeave(object sender, EventArgs e)
        {
            this.btn_lg.ForeColor = Color.Black;
        }

        private void btn_su_MouseEnter(object sender, EventArgs e)
        {
            this.btn_su.ForeColor = Color.Navy;
        }

        private void btn_su_MouseLeave(object sender, EventArgs e)
        {
            this.btn_su.ForeColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Panel panel1;
        private Label label2;
    }
}
