using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thibulator
{
    public partial class Thibsulator : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public Thibsulator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {

            if ((textBoxResult.Text == "0") || (isOperationPerformed))
                textBoxResult.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBoxResult.Text.Contains("."))
                    textBoxResult.Text += button.Text;
            }
            else
            textBoxResult.Text += button.Text;

        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                buttonCalc.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            } else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBoxResult.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }

        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelCurrentOperation.Text = "";
            textBoxResult.Text = "0";
            resultValue = 0;
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBoxResult.Text = (resultValue + Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "-":
                    textBoxResult.Text = (resultValue - Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (resultValue * Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "/":
                    textBoxResult.Text = (resultValue / Double.Parse(textBoxResult.Text)).ToString();
                    break;
                default:
                    break;

            }

            resultValue = Double.Parse(textBoxResult.Text);
            labelCurrentOperation.Text = "";
        }

        

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void key_49(object sender, KeyPressEventArgs e)
        {

        }
    }
}
