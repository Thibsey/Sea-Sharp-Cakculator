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
        
       

        private void numberKey(object sender, KeyEventArgs e)
        {

            //if ((textBoxResult.Text == "0") || (isOperationPerformed))
                //textBoxResult.Clear();
            //isOperationPerformed = false;
            
            switch (e.KeyCode.ToString())
            {
                case "D1":
                    textBoxResult.Text += "1";
                    break;
                case "NumPad1":
                    textBoxResult.Text += "1";
                    break;
                case "D2":
                    textBoxResult.Text += "2";
                    break;
                case "NumPad2":
                    textBoxResult.Text += "2";
                    break;
                case "D3":
                    textBoxResult.Text += "3";
                    break;
                case "NumPad3":
                    textBoxResult.Text += "3";
                    break;
                case "D4":
                    textBoxResult.Text += "4";
                    break;
                case "NumPad4":
                    textBoxResult.Text += "4";
                    break;
                case "D5":
                    textBoxResult.Text += "5";
                    break;
                case "NumPad5":
                    textBoxResult.Text += "5";
                    break;
                case "D6":
                    textBoxResult.Text += "6";
                    break;
                case "NumPad6":
                    textBoxResult.Text += "6";
                    break;
                case "D7":
                    textBoxResult.Text += "7";
                    break;
                case "NumPad7":
                    textBoxResult.Text += "7";
                    break;
                case "D8":
                    textBoxResult.Text += "8";
                    break;
                case "NumPad8":
                    textBoxResult.Text += "8";
                    break;
                case "D9":
                    textBoxResult.Text += "9";
                    break;
                case "NumPad9":
                    textBoxResult.Text += "9";
                    break;
                case "D0":
                    textBoxResult.Text += "0";
                    break;
                case "NumPad0":
                    textBoxResult.Text += "0";
                    break;
                default:
                    break;
            }
        }

        private void operatorPress(object sender, KeyEventArgs e)
        {
            if (resultValue != 0)
            {
                buttonCalc.PerformClick();
                switch (e.KeyCode.ToString())
                {
                    case "OemPeriod":
                        operationPerformed = ".";
                        labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                        isOperationPerformed = true;
                        break;
                    case "Decimal":
                        textBoxResult.Text = ".";
                        break;
                    case "Oemplus":
                        operationPerformed = "+";
                        labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                        isOperationPerformed = true;
                        break;
                    case "Add":
                        operationPerformed = "+";
                        labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                        isOperationPerformed = true;
                        break;
                    case "OemMinus":
                        operationPerformed = "-";
                        labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                        isOperationPerformed = true;
                        break;
                    case "Subtract":
                        operationPerformed = "-";
                        labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                        isOperationPerformed = true;
                        break;
                    case "Multiply":
                        operationPerformed = "*";
                        labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                        isOperationPerformed = true;
                        break;
                    case "OemQuestion":
                        operationPerformed = "/";
                        labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                        isOperationPerformed = true;
                        break;
                    case "Divide":
                        operationPerformed = "/";
                        labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                        isOperationPerformed = true;
                        break;
                    default:
                        break;
                }

            }
            else
            {
                switch (e.KeyCode.ToString())
                {
                    case "OemPeriod":
                        operationPerformed = ".";
                        labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                        isOperationPerformed = true;
                        break;
                    case "Decimal":
                        textBoxResult.Text = ".";
                        break;
                    case "Oemplus":
                        operationPerformed = "+";
                        labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                        isOperationPerformed = true;
                        break;
                    case "Add":
                        operationPerformed = "+";
                        labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                        isOperationPerformed = true;
                        break;
                    case "OemMinus":
                        operationPerformed = "-";
                        labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                        isOperationPerformed = true;
                        break;
                    case "Subtract":
                        operationPerformed = "-";
                        labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                        isOperationPerformed = true;
                        break;
                    case "Multiply":
                        operationPerformed = "*";
                        labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                        isOperationPerformed = true;
                        break;
                    case "OemQuestion":
                        operationPerformed = "/";
                        labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                        isOperationPerformed = true;
                        break;
                    case "Divide":
                        operationPerformed = "/";
                        labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                        isOperationPerformed = true;
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
