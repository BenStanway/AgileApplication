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
  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                Form myForm = new sPark();
                myForm.Show();
                
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form myForm = new DS();
                myForm.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form myForm = new Teach();
              myForm.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form myForm = new guest();
                myForm.Show();

            this.Hide();
        }
        //public class Carpark
        //{
        //    int AppliedScience{get; set;}
        //    public Carpark()
        //        {

        //        }
    }


}
