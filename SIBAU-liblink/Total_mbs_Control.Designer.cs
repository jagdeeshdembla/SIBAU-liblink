namespace SIBAU_liblink
{
    partial class Total_mbs_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Total_mbs_Control));
            panel_top = new Panel();
            label3 = new Label();
            pictureBox8 = new PictureBox();
            panel1 = new Panel();
            label4 = new Label();
            label1 = new Label();
            DGV_tms = new DataGridView();
            panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_tms).BeginInit();
            SuspendLayout();
            // 
            // panel_top
            // 
            panel_top.Controls.Add(label3);
            panel_top.Controls.Add(pictureBox8);
            panel_top.Dock = DockStyle.Top;
            panel_top.Location = new Point(0, 0);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(884, 100);
            panel_top.TabIndex = 96;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(355, 7);
            label3.Name = "label3";
            label3.Size = new Size(247, 37);
            label3.TabIndex = 95;
            label3.Text = "Total Members";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(4, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(140, 92);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 94;
            pictureBox8.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 469);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 47);
            panel1.TabIndex = 97;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(499, 11);
            label4.Name = "label4";
            label4.Size = new Size(22, 24);
            label4.TabIndex = 98;
            label4.Text = "0";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(325, 11);
            label1.Name = "label1";
            label1.Size = new Size(166, 24);
            label1.TabIndex = 97;
            label1.Text = "Total Members:";
            // 
            // DGV_tms
            // 
            DGV_tms.BackgroundColor = Color.White;
            DGV_tms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_tms.Dock = DockStyle.Fill;
            DGV_tms.Location = new Point(0, 100);
            DGV_tms.Name = "DGV_tms";
            DGV_tms.Size = new Size(884, 369);
            DGV_tms.TabIndex = 98;
            // 
            // Total_mbs_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(DGV_tms);
            Controls.Add(panel1);
            Controls.Add(panel_top);
            Name = "Total_mbs_Control";
            Size = new Size(884, 516);
            panel_top.ResumeLayout(false);
            panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_tms).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_top;
        private PictureBox pictureBox8;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private Label label4;
        private DataGridView DGV_tms;
    }
}
