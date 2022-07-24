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
    public partial class sPark : Form
    {
        int Wilberforce = 150;
        int SportsCarPark = 60;
        public sPark()
        {
            InitializeComponent();
            
        }

        private void sPark_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            --Wilberforce;
            label1.Text = Wilberforce.ToString();
            if (Wilberforce == 1)
            { 
                label1.Text= "Sorry no more spaces are available";
                label2.Text = "";   
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            --SportsCarPark;
            label4.Text = SportsCarPark.ToString();
            if (SportsCarPark == 1)
            {
                label3.Text = "Sorry no more spaces are available";
                label4.Text = "";
                
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form myForm = new Form1();
            myForm.Show();

            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form myForm = new StudentCarPark();
            myForm.Show();

            this.Hide();
        }
    }
}
