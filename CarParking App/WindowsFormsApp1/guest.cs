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

    public partial class guest : Form
    {
        int AppliedScience = 40;
        int Libary = 10;
        int Calder = 20;
        int Sports = 50;
        int Wilberforce = 100;
        int SalmonGrove =40;
        int MainEntrance = 20;
        int Dearne = 15;
        int Wharfe = 10;



        public guest()
        {
            InitializeComponent();
            
        }
        private void guest_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            --Wilberforce;
            label1.Text = Wilberforce.ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form myForm = new reserve();
            myForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            --Libary;
            label2.Text = Libary.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            --Calder;
            label3.Text = Calder.ToString();
            if (Calder == 1)
            {
                label3.Text = ("");
                label8.Text = ("there are no more spaces");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            --Sports;
            label4.Text = Sports.ToString();
            if (Sports ==1)
            {
                label4.Text =("there are no more spaces");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form myForm = new Form1();
            myForm.Show();

            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            --MainEntrance;
            label14.Text = MainEntrance.ToString();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            --Wharfe;
            label15.Text = Wharfe.ToString();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            --SalmonGrove;
            label16.Text = SalmonGrove.ToString();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            --Dearne;
            label17.Text = Dearne.ToString();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form myForm = new MapGuests();
            myForm.Show();

            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
