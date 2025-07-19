using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculator
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        double num, num2;
        char op = '\0';
        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            num = Convert.ToDouble(textBox1.Text);
            op = '+';
            textBox1.Text = "";
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            num = Convert.ToDouble(textBox1.Text);
            op = '-';
            textBox1.Text = "";
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            num = Convert.ToDouble(textBox1.Text);
            op = '*';
            textBox1.Text = "";
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            num = Convert.ToDouble(textBox1.Text);
            op = '/';
            textBox1.Text = "";
        }

        private void button15_Click_1(object sender, EventArgs e)
        {

            num2 = Convert.ToDouble(textBox1.Text);
            if (op == '+')
            {
                textBox1.Text = (num + num2).ToString();
            }
            else if (op == '-')
            {
                textBox1.Text = (num - num2).ToString();
            }
            else if (op == '*')
            {
                textBox1.Text = (num * num2).ToString();
            }
            else if (op == '/')
            {
                textBox1.Text = (num / num2).ToString();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            num2 = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

     

     

  
    }
}
