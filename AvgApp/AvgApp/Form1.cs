using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvgApp
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
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double avg = (num1 + num2) / 2;

                string avgs = Convert.ToString(avg);

                textBox3.Text = avgs;
            }
            catch (System.FormatException)
            {
                textBox1.Text = "Numbers Only";
                textBox2.Text = "Numbers Only";

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double numone = Convert.ToDouble(textBox4.Text);
                double numtwo = Convert.ToDouble(textBox5.Text);

                Random rand = new Random();
                double numrand = rand.Next(Convert.ToInt32(numone), Convert .ToInt32(numtwo));

                string names = Convert.ToString(numrand);

               
                textBox1.Text = names;
            }
            catch (System.FormatException)
            {
                
                textBox1.Text = "Numbers Only";
            }
            catch (System.ArgumentOutOfRangeException)
            {
                
                textBox1.Text = "Check Min/Max";
            }
            catch (System.OverflowException)
            {
                textBox4.Text = "Number To Large";
                textBox5.Text = "Number To Large";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int numone = Convert.ToInt32(textBox4.Text);
                int numtwo = Convert.ToInt32(textBox5.Text);

                Random rand = new Random();
                int numrand = rand.Next(numone, numtwo);

                string names = Convert.ToString(numrand);

                textBox2.Text = names;
                
            }
            catch (System.FormatException)
            {
                textBox2.Text = "Numbers Only";
              
            }
            catch (System.ArgumentOutOfRangeException)
            {
                textBox2.Text = "Check Min/Max";
                
            }
            catch (System.OverflowException)
            {
                textBox4.Text = "Number To Large";
                textBox5.Text = "Number To Large";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                int numone = Convert.ToInt32(textBox4.Text);
                int numtwo = Convert.ToInt32(textBox5.Text);

                Random rand = new Random();
                int numrand = rand.Next(numone, numtwo);

                string names = Convert.ToString(numrand);

                textBox2.Text = names;
                textBox1.Text = names;
            }
            catch (System.FormatException)
            {
                textBox2.Text = "Numbers Only";
                textBox1.Text = "Numbers Only";
            }
            catch (System.ArgumentOutOfRangeException)
            {
                textBox2.Text = "Check Min/Max";
                textBox1.Text = "Check Min/Max";
            }
        }
    }
}
