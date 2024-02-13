namespace Hotel_Management_System
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(103, 177, 198);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-22, -48);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 708);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2024_02_06_at_11_05_12_PM_removebg_preview;
            pictureBox1.Location = new Point(35, 169);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 393);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(595, 155);
            label4.Name = "label4";
            label4.Size = new Size(161, 73);
            label4.TabIndex = 8;
            label4.Text = "Login";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(456, 406);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 7;
            label3.Text = "Forgot Your Password?";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(60, 19);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter UserName";
            textBox1.Size = new Size(276, 27);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(103, 177, 198);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(576, 465);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(120, 49);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(60, 11);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Enter Password";
            textBox2.Size = new Size(276, 26);
            textBox2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(833, -1);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 135);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(530, 547);
            label6.Name = "label6";
            label6.Size = new Size(121, 18);
            label6.TabIndex = 11;
            label6.Text = "Not a Member ?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.ForeColor = Color.FromArgb(103, 177, 198);
            label7.Location = new Point(657, 547);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 12;
            label7.Text = "Sign Up";
            label7.Click += label7_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox3.Image = Properties.Resources.username;
            pictureBox3.Location = new Point(0, 15);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Gainsboro;
            pictureBox4.Image = Properties.Resources.password;
            pictureBox4.Location = new Point(3, 11);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 39);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(456, 270);
            panel2.Name = "panel2";
            panel2.Size = new Size(339, 60);
            panel2.TabIndex = 57;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(textBox2);
            panel3.Location = new Point(456, 349);
            panel3.Name = "panel3";
            panel3.Size = new Size(339, 54);
            panel3.TabIndex = 58;
            panel3.Paint += panel3_Paint;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(981, 691);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label7;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Panel panel3;
    }
}
