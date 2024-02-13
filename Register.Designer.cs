namespace Hotel_Management_System
{
    partial class Register
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            SignUp = new Button();
            UserType = new ComboBox();
            pictureBox2 = new PictureBox();
            linkLabel1 = new LinkLabel();
            pictureBox5 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            errorProvider5 = new ErrorProvider(components);
            pictureBox3 = new PictureBox();
            UserName = new TextBox();
            pictureBox7 = new PictureBox();
            textBox1 = new TextBox();
            pictureBox6 = new PictureBox();
            ConfirmPassword = new TextBox();
            pictureBox4 = new PictureBox();
            Password = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(103, 177, 198);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-67, -53);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 760);
            panel1.TabIndex = 12;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(103, 177, 198);
            label5.Location = new Point(726, 651);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 21;
            label5.Text = "Login";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(621, 29);
            label4.Name = "label4";
            label4.Size = new Size(212, 73);
            label4.TabIndex = 19;
            label4.Text = "Sign Up";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(443, 513);
            label3.Name = "label3";
            label3.Size = new Size(160, 20);
            label3.TabIndex = 18;
            label3.Text = "Forgot Your PassWord?";
            // 
            // SignUp
            // 
            SignUp.BackColor = Color.FromArgb(103, 177, 198);
            SignUp.ForeColor = SystemColors.ActiveCaptionText;
            SignUp.Location = new Point(652, 579);
            SignUp.Margin = new Padding(3, 4, 3, 4);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(120, 49);
            SignUp.TabIndex = 17;
            SignUp.Text = "SignUp";
            SignUp.UseVisualStyleBackColor = false;
            SignUp.Click += button1_Click;
            // 
            // UserType
            // 
            UserType.ForeColor = SystemColors.WindowFrame;
            UserType.FormattingEnabled = true;
            UserType.Items.AddRange(new object[] { "Employee", "customer" });
            UserType.Location = new Point(512, 170);
            UserType.Margin = new Padding(3, 4, 3, 4);
            UserType.Name = "UserType";
            UserType.Size = new Size(342, 28);
            UserType.TabIndex = 23;
            UserType.Text = "User Type";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1039, -1);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 135);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.Silver;
            linkLabel1.Font = new Font("Mongolian Baiti", 9.75F);
            linkLabel1.LinkColor = Color.DimGray;
            linkLabel1.Location = new Point(524, 651);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(199, 18);
            linkLabel1.TabIndex = 26;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already Have an Account?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(103, 177, 198);
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(446, 170);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(39, 44);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 29;
            pictureBox5.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            errorProvider5.ContainerControl = this;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(103, 177, 198);
            pictureBox3.Image = Properties.Resources.username;
            pictureBox3.Location = new Point(443, 240);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 37;
            pictureBox3.TabStop = false;
            // 
            // UserName
            // 
            UserName.BackColor = Color.FromArgb(224, 224, 224);
            UserName.BorderStyle = BorderStyle.None;
            UserName.Location = new Point(512, 240);
            UserName.Margin = new Padding(3, 4, 3, 4);
            UserName.Multiline = true;
            UserName.Name = "UserName";
            UserName.PlaceholderText = "Enter UserName";
            UserName.Size = new Size(349, 41);
            UserName.TabIndex = 34;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(103, 177, 198);
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(443, 310);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(39, 47);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 53;
            pictureBox7.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(512, 310);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter Email";
            textBox1.Size = new Size(349, 47);
            textBox1.TabIndex = 51;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(103, 177, 198);
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(443, 464);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(39, 39);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 52;
            pictureBox6.TabStop = false;
            // 
            // ConfirmPassword
            // 
            ConfirmPassword.BackColor = Color.FromArgb(224, 224, 224);
            ConfirmPassword.BorderStyle = BorderStyle.None;
            ConfirmPassword.Location = new Point(505, 464);
            ConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            ConfirmPassword.Multiline = true;
            ConfirmPassword.Name = "ConfirmPassword";
            ConfirmPassword.PasswordChar = '*';
            ConfirmPassword.PlaceholderText = "Confirm Password";
            ConfirmPassword.Size = new Size(356, 45);
            ConfirmPassword.TabIndex = 49;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(103, 177, 198);
            pictureBox4.Image = Properties.Resources.password;
            pictureBox4.Location = new Point(443, 386);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 39);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 48;
            pictureBox4.TabStop = false;
            // 
            // Password
            // 
            Password.BackColor = Color.FromArgb(224, 224, 224);
            Password.BorderStyle = BorderStyle.None;
            Password.Location = new Point(512, 380);
            Password.Margin = new Padding(3, 4, 3, 4);
            Password.Multiline = true;
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.PlaceholderText = "Enter Password";
            Password.Size = new Size(349, 45);
            Password.TabIndex = 46;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 707);
            Controls.Add(pictureBox7);
            Controls.Add(textBox1);
            Controls.Add(pictureBox6);
            Controls.Add(ConfirmPassword);
            Controls.Add(pictureBox4);
            Controls.Add(Password);
            Controls.Add(pictureBox3);
            Controls.Add(UserName);
            Controls.Add(pictureBox5);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox2);
            Controls.Add(UserType);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(SignUp);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button SignUp;
        private ComboBox UserType;
        private PictureBox pictureBox2;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox5;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private ErrorProvider errorProvider5;
        private PictureBox pictureBox7;
        private TextBox textBox1;
        private PictureBox pictureBox6;
        private TextBox ConfirmPassword;
        private PictureBox pictureBox4;
        private TextBox Password;
        private PictureBox pictureBox3;
        private TextBox UserName;
    }
}