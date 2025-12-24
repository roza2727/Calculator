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
        double firstNumber = 0;
        string operation = "";
        bool isOperationPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        // ===== Common method for number buttons =====
        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (isOperationPressed)
            {
                textBox1.Clear();
                isOperationPressed = false;
            }

            textBox1.Text += btn.Text;
        }

        // ===== Common method for operator buttons =====
        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            firstNumber = double.Parse(textBox1.Text);
            operation = btn.Text;
            isOperationPressed = true;
        }

        // ===== Equals button =====
        private void button12_Click(object sender, EventArgs e)
        {
            double secondNumber = double.Parse(textBox1.Text);
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber != 0)
                        result = firstNumber / secondNumber;
                    else
                    {
                        MessageBox.Show("Cannot divide by zero");
                        return;
                    }
                    break;
            }

            textBox1.Text = result.ToString();
        }

        // ===== Clear (DEL) =====
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            firstNumber = 0;
            operation = "";
        }

        // ===== Number buttons =====
        private void button1_Click(object sender, EventArgs e) => Number_Click(sender, e); //1
        private void button2_Click(object sender, EventArgs e) => Number_Click(sender, e); //2
        private void button3_Click(object sender, EventArgs e) => Number_Click(sender, e); //3
        private void button4_Click(object sender, EventArgs e) => Number_Click(sender, e); //4
        private void button5_Click(object sender, EventArgs e) => Number_Click(sender, e); //5
        private void button6_Click(object sender, EventArgs e) => Number_Click(sender, e); //6
        private void button7_Click(object sender, EventArgs e) => Number_Click(sender, e); //7
        private void button8_Click(object sender, EventArgs e) => Number_Click(sender, e); //8
        private void button9_Click(object sender, EventArgs e) => Number_Click(sender, e); //9

        // ===== Operator buttons =====
        private void button10_Click(object sender, EventArgs e) => Operator_Click(sender, e); // +
        private void button11_Click(object sender, EventArgs e) => Operator_Click(sender, e); // -
        private void button13_Click(object sender, EventArgs e) => Operator_Click(sender, e); // *
        private void button14_Click(object sender, EventArgs e) => Operator_Click(sender, e); // /
    }
}