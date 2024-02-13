﻿using Hotel_Management_System.User_Control;
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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            UC_EmployeeProfile uc = new UC_EmployeeProfile();
            addUserControl(uc);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer3.Controls.Clear();
            panelContainer3.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_EmployeeProfile uc = new UC_EmployeeProfile();
            addUserControl(uc);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UC_EmployeeRooms uc = new UC_EmployeeRooms();
            addUserControl(uc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UC_EmployeeClient uc = new UC_EmployeeClient();
            addUserControl(uc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UC_EmployeeReservation uc = new UC_EmployeeReservation();
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
