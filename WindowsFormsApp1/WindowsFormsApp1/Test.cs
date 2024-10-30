using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TestProgram testProgram = new TestProgram();
            int result = testProgram.addTwoNums(3, 2);
            MessageBox.Show("The result is: " + result);
        }
    }
}
