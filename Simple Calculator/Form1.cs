using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
                            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            input += "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            input += "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            input += "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            input += "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            input += "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            input += "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            input += "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            input += "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            input += "9";
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            input += "0";
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;

        }

        private void Button12_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }
    }
}
