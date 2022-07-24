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
    public partial class cpa : Form
    {
        int Wilberforce = 100;
        int AppliedScience = 30;
        int Libary = 20;
        int Hertford = 50;
        int Salmon = 20;
        int Calder = 20;
        int Sports = 60;
        int Chemistry = 20;
        int MainEntrance = 40;
        int Venn = 30;

        public cpa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            --Libary;
            label5.Text = Libary.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            --AppliedScience;
            label4.Text = AppliedScience.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            --Hertford;
            label1.Text = Hertford.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form myForm = new Form1();
            myForm.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form myForm = new reserve();
            myForm.Show();

            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            --Calder;
            label2.Text = Calder.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            --MainEntrance;
            label3.Text = MainEntrance.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            --Sports;
            label6.Text = Sports.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            --Wilberforce;
            label7.Text = Wilberforce.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            --Chemistry;
            label8.Text = Chemistry.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            --Salmon;
            label9.Text = Salmon.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            --Venn;
            label10.Text = Venn.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form myForm = new Map();
            myForm.Show();

            this.Hide();
        }
    }
}
