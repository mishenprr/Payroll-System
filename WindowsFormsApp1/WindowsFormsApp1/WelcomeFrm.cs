using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WelcomeFrm : Form
    {
        public WelcomeFrm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login obj = new Login();
            obj.Show();
        }
    }
}
