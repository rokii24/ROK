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
    public partial class MyProfile : Form
    {
        public MyProfile()
        {
            InitializeComponent();
            UC_MyProfile uc = new UC_MyProfile();
            addUserControl(uc);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer2.Controls.Clear();
            panelContainer2.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_MyProfile uc = new UC_MyProfile();
            addUserControl(uc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Uc_ProfileRooms uc = new Uc_ProfileRooms();
            addUserControl(uc);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UC_ProfileReservation uc = new UC_ProfileReservation();
            addUserControl(uc);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UC_ProfileFeedback uc = new UC_ProfileFeedback();
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
