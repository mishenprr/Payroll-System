using System;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployee obj = new frmEmployee();
            obj.Show();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSalary obj = new frmSalary();
            obj.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSettings obj = new frmSettings();
            obj.Show();
        }
    }
}
