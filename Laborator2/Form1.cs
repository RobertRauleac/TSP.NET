using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Lab2
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string op1 = string.Empty;
        string op2 = string.Empty;
        char op;
        double result = 0.0;
        public Form1()
        {
            InitializeComponent();

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void button13_Click(object sender, EventArgs e) // +
        {
            op1 = input;
            op = '+';
            input = string.Empty;
        }

        private void button14_Click(object sender, EventArgs e) // -
        {
            op1 = input;
            op = '-';
            input = string.Empty;
        }

        private void button15_Click(object sender, EventArgs e) // *
        {
            op1 = input;
            op = '*';
            input = string.Empty;
        }

        private void button16_Click(object sender, EventArgs e) // /
        {
            op1 = input;
            op = '/';
            input = string.Empty;
        }

        private void button10_Click(object sender, EventArgs e) // .
        {
            this.textBox1.Text = "";
            input += ',';
            this.textBox1.Text += input;
        }

        private void button12_Click(object sender, EventArgs e) // =
        {
            op2 = input;
            double num1, num2;
            //double.TryParse(op1, out num1);
            //double.TryParse(op2, out num2);
            num1 = Convert.ToDouble(op1);
            //Console.WriteLine(num1);
            num2 = Convert.ToDouble(op2);

            this.textBox1.Text = "";
            this.input = string.Empty;
            this.op1 = string.Empty;
            this.op2 = string.Empty;

            if (op == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if (op == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (op == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (op == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "ERROR";
                }

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            input += "C";
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.op1 = string.Empty;
            this.op2 = string.Empty;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
                  
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
    }
}
