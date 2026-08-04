using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace calcs
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
                double l1 = Convert.ToDouble(textBox1.Text);
                double l2 = Convert.ToDouble(textBox2.Text);
                textBox3.Text = (l1 + l2).ToString();
            }
            catch 
            {
                textBox3.Text = "error:";


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double l1 = Convert.ToDouble(textBox1.Text);
                double l2 = Convert.ToDouble(textBox2.Text);
                textBox3.Text = (l1 - l2).ToString();
            }
            catch
            {
                textBox3.Text = "error:";


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double l1 = Convert.ToDouble(textBox1.Text);
                double l2 = Convert.ToDouble(textBox2.Text);
                textBox3.Text = (l1 * l2).ToString();
            }
            catch
            {
                textBox3.Text = "error:";


            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double l1 = Convert.ToDouble(textBox1.Text);
                double l2 = Convert.ToDouble(textBox2.Text);
                textBox3.Text = (l1 / l2).ToString();
            }
            catch
            {
                textBox3.Text = "error:";


            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox3.Text ;
        }
    }
}
