using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp1
{
   
    public partial class reserve : Form
    {
        
        int ID = 1928363;
        
        public reserve()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" )
            {
                label5.Text = "You have not filled in all of the boxes";
            }

            //else if(textBox1.Text=="")
            //{
            //    label5.Text = "You have missed you're first name";
            //}
            //else if (textBox2.Text == "")
            //{
            //    label5.Text = "You have missed you're last name";
            //}
            //else if (textBox1.Text == "")
            //{
            //    label5.Text = "You have missed you're first name";
            //}


            else
            {
                label4.Text = "You have a reserved spot " + textBox6.Text + " " + textBox3.Text;

                label5.Text = ID.ToString();
                --ID;

                label5.Text = "ID Number: " + ID;


                StreamReader sr = new StreamReader(Application.StartupPath + "\\Logbook\\" + "LOG.txt");
                string oldData = sr.ReadLine();
                sr.Close();

                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Logbook\\" + "LOG.txt");



                string[] data = new string[2340];
                data[0] = label1.Text + " " + textBox1.Text;
                data[1] = label9.Text + " " + textBox6.Text;
                data[2] = label2.Text + " " + textBox2.Text;
                data[3] = label3.Text + " " + textBox3.Text;
               
                data[4] = label7.Text + " " + textBox5.Text;
                data[5] = label5.Text;


                sw.WriteLine(data[0] + " " + data[1] + " " + data[2] + " " + data[3] + " " + data[4] + " "+ data[5]+ " " + dateTimePicker1 + " "+ Environment.NewLine+ Environment.NewLine+ " "+oldData);
                

                // dateTimePicker1;

                sw.Close();

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox5.Clear();
                textBox6.Clear();
            }
        }

      

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void reserve_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form myForm = new Form1();
            myForm.Show();

            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
