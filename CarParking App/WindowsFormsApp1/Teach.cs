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
    public partial class Teach : Form
    {
        int Sports = 60;
        int wilberforce = 150;
        int MainEntrance = 20;
        int Science = 50;
        int TeachersMain = 100;
        public Teach()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form myForm = new Form1();
            myForm.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            --wilberforce;
            label3.Text = wilberforce.ToString();
            if (Sports == 1)
            {
                label2.Text = "Sorry no more spaces are available";
                label3.Text = "";

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            --Sports;
            label4.Text = Sports.ToString();
            if (Sports == 1)
            {
                label1.Text = "Sorry no more spaces are available";
                label4.Text = "";

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            --MainEntrance;
            label6.Text = MainEntrance.ToString();
            if (MainEntrance == 1)
            {
                label6.Text = "Sorry no more spaces are available";
                label7.Text = "";

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            --Science;
            label9.Text = Science.ToString();
            if (Science == 1)
            {
                label9.Text = "Sorry no more spaces are available";
                label8.Text = "";

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            --TeachersMain;
            label11.Text = TeachersMain.ToString();
            if (TeachersMain == 1)
            {
                label11.Text = "Sorry no more spaces are available";
                label10.Text = "";

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form myForm = new TeachCar();
            myForm.Show();

            this.Hide();
        }

        private void Teach_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
