using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login secondForm = new Login();
            secondForm.ShowDialog();
            this.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login secondForm = new Login();
            secondForm.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserType.SelectedIndex == -1)
            {
                errorProvider1.SetError(UserType, "Please select a User Type.");
                return;
            }
            else
            {
                errorProvider1.SetError(UserType, "");
            }

            // Validation for UserName TextBox
            if (!Regex.IsMatch(UserName.Text, "^[a-zA-Z]+$"))
            {
                errorProvider2.SetError(UserName, "Username should only contain letters.");
                return;
            }
            else
            {
                errorProvider2.SetError(UserName, "");
            }

            // Validation for Email TextBox
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !textBox1.Text.Contains("@") || !textBox1.Text.Contains("."))
            {
                errorProvider3.SetError(textBox1, "Please enter a valid email address.");
                return;
            }
            else
            {
                errorProvider3.SetError(textBox1, "");
            }

            // Validation for Password TextBox
            if (string.IsNullOrWhiteSpace(Password.Text))
            {
                errorProvider4.SetError(Password, "Please enter a password.");
                return;
            }
            else
            {
                errorProvider4.SetError(Password, "");
            }

            // Validation for ConfirmPassword TextBox
            if (ConfirmPassword.Text != Password.Text)
            {
                errorProvider5.SetError(ConfirmPassword, "Passwords do not match.");
                return;
            }
            else
            {
                errorProvider5.SetError(ConfirmPassword, "");
            }
            this.Close();

            this.Hide();
            main secondForm = new main();
            secondForm.ShowDialog();
            this.Show();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
