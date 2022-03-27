using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        Double calculatedvalue = 0;
        string op = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_click.Text == "0") || (isOperationPerformed))
                textBox_click.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if(!textBox_click.Text.Contains("."))
                {
                    textBox_click.Text = textBox_click.Text + button.Text;
                }
            else
                textBox_click.Text = textBox_click.Text + button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(calculatedvalue!=0)
            {
                button18.PerformClick();
                op = button.Text;
                isOperationPerformed = true;
                currentlabel.Text = calculatedvalue + " " + op;
            }else
                op = button.Text;
                calculatedvalue = double.Parse(textBox_click.Text);
                isOperationPerformed = true;
                currentlabel.Text = calculatedvalue + " " + op;
        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            textBox_click.Text = "0";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox_click.Text = "0";
            calculatedvalue = 0;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case "+":
                    {
                        textBox_click.Text = (calculatedvalue + Double.Parse(textBox_click.Text)).ToString();
                        break;
                    }
                case "-":
                    {
                        textBox_click.Text = (calculatedvalue - Double.Parse(textBox_click.Text)).ToString();
                        break;
                    }
                case "*":
                    {
                        textBox_click.Text = (calculatedvalue * Double.Parse(textBox_click.Text)).ToString();
                        break;
                    }
                case "/":
                    {
                        textBox_click.Text = (calculatedvalue / Double.Parse(textBox_click.Text)).ToString();
                        break;
                    }
                default:
                    {
                        break;
                    }

            }
            calculatedvalue = Double.Parse(textBox_click.Text);
            currentlabel.Text = "";
        }
    }
}
