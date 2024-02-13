using System.Drawing.Drawing2D;

namespace Hotel_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register secondForm = new Register();
            secondForm.ShowDialog();
            // Show the second form
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))

            {
                errorProvider1.SetError(textBox1, "User is required");
                return;
            }
            else
            {
                errorProvider1.SetError(textBox1, string.Empty);
            }

            if (string.IsNullOrEmpty(textBox2.Text.Trim()))

            {
                errorProvider1.SetError(textBox2, "Please Enter Password");
                return;
            }
            else
            {
                errorProvider1.SetError(textBox2, string.Empty);
            }
            this.Hide();
            MyProfile secondForm = new MyProfile();
            secondForm.ShowDialog();
            this.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
