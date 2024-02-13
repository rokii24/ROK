using Hotel_Management_System.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            UC_Dasboard db = new UC_Dasboard();
            addUserControl(db);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Uc_Categories uc = new Uc_Categories();
            addUserControl(uc);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            UC_Rooms uc = new UC_Rooms();
            addUserControl(uc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UC_Clients uc = new UC_Clients();
            addUserControl(uc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UC_Users uc = new UC_Users();
            addUserControl(uc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Uc_Reservation uc = new Uc_Reservation();
            addUserControl(uc);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UC_Feedback uc = new UC_Feedback();
            addUserControl(uc);

        }
        private void button7_Click(object sender, EventArgs e)
        {
            UC_Dasboard uc = new UC_Dasboard();
            addUserControl(uc);

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login secondForm = new Login();
            secondForm.ShowDialog();
            this.Show();
        }
    }
}
