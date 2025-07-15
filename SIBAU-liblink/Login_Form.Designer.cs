namespace SIBAU_liblink
{
    partial class Login_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            btn_lg1 = new Button();
            label4 = new Label();
            hidden = new PictureBox();
            textBox2 = new TextBox();
            person = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hidden).BeginInit();
            ((System.ComponentModel.ISupportInitialize)person).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_lg1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(hidden);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(person);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(403, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 364);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(224, 213);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(17, 15);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label5.Location = new Point(24, 185);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 23;
            label5.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.Location = new Point(21, 121);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 22;
            label3.Text = "CMS-ID";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(145, 327);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(47, 15);
            linkLabel1.TabIndex = 21;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(28, 328);
            label2.Name = "label2";
            label2.Size = new Size(114, 13);
            label2.TabIndex = 20;
            label2.Text = "Create new account?";
            // 
            // btn_lg1
            // 
            btn_lg1.BackColor = SystemColors.HotTrack;
            btn_lg1.BackgroundImageLayout = ImageLayout.Center;
            btn_lg1.Cursor = Cursors.Hand;
            btn_lg1.FlatAppearance.BorderSize = 0;
            btn_lg1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_lg1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_lg1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_lg1.ForeColor = Color.White;
            btn_lg1.Location = new Point(21, 281);
            btn_lg1.Name = "btn_lg1";
            btn_lg1.Size = new Size(225, 38);
            btn_lg1.TabIndex = 19;
            btn_lg1.Text = "Login";
            btn_lg1.UseVisualStyleBackColor = false;
            btn_lg1.Click += button1_Click;
            btn_lg1.MouseEnter += button1_MouseEnter;
            btn_lg1.MouseLeave += button1_MouseLeave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(148, 237);
            label4.Name = "label4";
            label4.Size = new Size(99, 13);
            label4.TabIndex = 18;
            label4.Text = "Forget Password?";
            label4.MouseEnter += label4_MouseEnter;
            label4.MouseLeave += label4_MouseLeave;
            // 
            // hidden
            // 
            hidden.Cursor = Cursors.Hand;
            hidden.Image = (Image)resources.GetObject("hidden.Image");
            hidden.Location = new Point(224, 213);
            hidden.Name = "hidden";
            hidden.Size = new Size(17, 15);
            hidden.SizeMode = PictureBoxSizeMode.Zoom;
            hidden.TabIndex = 15;
            hidden.TabStop = false;
            hidden.Click += hidden_Click;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(27, 209);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(217, 23);
            textBox2.TabIndex = 13;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.MouseLeave += textBox2_MouseLeave;
            textBox2.MouseHover += textBox2_MouseHover;
            // 
            // person
            // 
            person.Cursor = Cursors.Hand;
            person.Image = (Image)resources.GetObject("person.Image");
            person.Location = new Point(224, 150);
            person.Name = "person";
            person.Size = new Size(17, 15);
            person.SizeMode = PictureBoxSizeMode.Zoom;
            person.TabIndex = 12;
            person.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(25, 146);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "CMS-ID";
            textBox1.Size = new Size(219, 23);
            textBox1.TabIndex = 4;
            textBox1.MouseLeave += textBox1_MouseLeave;
            textBox1.MouseHover += textBox1_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(109, 66);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(84, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1084, 561);
            Controls.Add(panel1);
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Login";
            WindowState = FormWindowState.Maximized;
            Load += Login_Form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)hidden).EndInit();
            ((System.ComponentModel.ISupportInitialize)person).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private PictureBox person;
        private PictureBox hidden;
        private TextBox textBox2;
        private Label label4;
        private Button btn_lg1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label label3;
        private Label label5;
        private PictureBox pictureBox2;
    }
}