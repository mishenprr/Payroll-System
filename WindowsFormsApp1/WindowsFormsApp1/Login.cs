using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if ((username == "Admin") && (password == "1234"))
            {
                this.Hide();
                MessageBox.Show("Login Successful");
                Dashboard obj = new Dashboard();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Try Again!");
            }
        }
    }
}
