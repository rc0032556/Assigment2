using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                double R1 = Convert.ToDouble(textBox1.Text);
                double R2 = Convert.ToDouble(textBox2.Text);
                double R3 = Convert.ToDouble(textBox3.Text);
                double R4 = Convert.ToDouble(textBox4.Text);
                double R5 = Convert.ToDouble(textBox5.Text);


                double Rt = 1.0 / (1.0 / R1 + 1.0 / R2 + 1.0 / R3 + 1.0 / R4 + 1.0 / R5);
                label6.Text = "Total Resistance = " + Rt;

            }
            catch
            {
                MessageBox.Show("Error no value found");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                double R1 = Convert.ToDouble(textBox1.Text);
                double R2 = Convert.ToDouble(textBox2.Text);
                double R3 = Convert.ToDouble(textBox3.Text);
                double R4 = Convert.ToDouble(textBox4.Text);
                


                double Rt = 1.0 / (1.0 / R1 + 1.0 / R2 + 1.0 / R3 + 1.0 / R4);
                label6.Text = "Total Resistance = " + Rt;

            }
            catch
            {
                MessageBox.Show("Error no value found");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                double R1 = Convert.ToDouble(textBox1.Text);
                double R2 = Convert.ToDouble(textBox2.Text);
                double R3 = Convert.ToDouble(textBox3.Text);
                



                double Rt = 1.0 / (1.0 / R1 + 1.0 / R2 + 1.0 / R3);
                label6.Text = "Total Resistance = " + Rt;

            }
            catch
            {
                MessageBox.Show("Error no value found");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                double R1 = Convert.ToDouble(textBox1.Text);
                double R2 = Convert.ToDouble(textBox2.Text);
           

                double Rt = 1.0 / (1.0 / R1 + 1.0 / R2);
                label6.Text = "Total Resistance = " + Rt;

            }
            catch
            {
                MessageBox.Show("Error no value found");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                double R1 = Convert.ToDouble(textBox6.Text);
                double R2 = Convert.ToDouble(textBox7.Text);
                double R3 = Convert.ToDouble(textBox8.Text);
                double R4 = Convert.ToDouble(textBox9.Text);
                double R5 = Convert.ToDouble(textBox10.Text);


                double Rt = ( R1 + R2 + R3 + R4 + R5);
                label12.Text = "Total Resistance = " + Rt;

            }
            catch
            {
                MessageBox.Show("Error no value found");
            }
        }



    }
}
        
    

