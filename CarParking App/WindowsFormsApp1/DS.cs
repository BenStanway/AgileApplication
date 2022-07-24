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
    public partial class DS : Form
    {
        public DS()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form myForm = new sPark();
            myForm.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form myForm = new cpa();
            myForm.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form myForm = new Form1();
            myForm.Show();

            this.Hide();
        }
    }
}
