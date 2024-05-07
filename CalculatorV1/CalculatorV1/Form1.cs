using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorV1
{
    public partial class Calculator : Form
    {
        double result = 0;
        String opt = "";
        Boolean isOptPerformed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void numBtn_Click(object sender, EventArgs e)
        {
            if(textBox_result.Text == "0" || isOptPerformed)
            {
                textBox_result.Clear();
            }

            isOptPerformed = false;
            Button button = sender as Button;

            if(button.Text == ".")
            {
                if(!textBox_result.Text.Contains(".")) {
                    textBox_result.Text = textBox_result.Text + button.Text;
                }
            }
            else
            {
                textBox_result.Text = textBox_result.Text + button.Text;
            }
        }

        private void ClearNum_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
        }

        private void ClearAllNum_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            result = 0;
        }

        private void optBtn_Click(Object sender, EventArgs e)
        {
            Button button = sender as Button;
            opt = button.Text;
            isOptPerformed = true;

            if (result != 0)
            {
                equal.PerformClick();
            }
            else
            {
                result = double.Parse(textBox_result.Text);
            }
        }

        private void equalTo_Click(object sender, EventArgs e)
        {
            switch (opt)
            {
                case "+":
                    result += double.Parse(textBox_result.Text);
                    break;
                case "-":
                    result -= double.Parse(textBox_result.Text);
                    break;
                case "x":
                    result *= double.Parse(textBox_result.Text);
                    break;
                case "/":
                    result /= double.Parse(textBox_result.Text);
                    break;
                default:
                    break;
            }
            textBox_result.Text = result.ToString();
        }
    }
}
