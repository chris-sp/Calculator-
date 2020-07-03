using Calculator.Calculations.operandNo;
using Calculator.Calculations.operandTwo;
using Calculator.Interfaces;
using System;
using System.Windows;

namespace Calculator
{    
    public partial class MainWindow : Window
    {
        string operand = "";
        ICalculation<decimal> @operator; // the "@" symbol allows you to use reserved words.

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            textDisplay.Text = "0";
            operand = "0";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "1";
            operand = "1";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "2";
            operand = "2";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "3";
            operand = "3";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "4";
            operand = "4";
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "5";
            operand = "5";
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "6";
            operand = "6";
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "7";
            operand = "7";
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "8";
            operand = "8";
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "9";
            operand = "9";
        }

        private void buttonEquals_Click(object sender, RoutedEventArgs e)
        {

            (@operator as ITwoOperandCalculation<decimal>).Operand2 = Decimal.Parse(operand);
            decimal add_value = @operator.Calculate();
            textDisplay.Text = textDisplay.Text + "=" + add_value.ToString();
            if (textDisplay.Text == "+")
            {

            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////
        // THERE IS ALSO THIS WAY TO CONVERT SOMETHING TO DECIMAL BUT WE NEED TO SET IT FIRST  //
        //                                                                                     //
        // decimal decimalValue                                                                //
        // decimalValue = System.Convert.ToDecimal(stringVal)                                  //
        /////////////////////////////////////////////////////////////////////////////////////////

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            @operator = new Addition { Operand1 = Decimal.Parse(operand) }; // convert the string to its equivalent decimal.
            textDisplay.Text = textDisplay.Text + "+";
        }

        private void buttonSub_Click(object sender, RoutedEventArgs e)
        {
            @operator = new Addition { Operand1 = Decimal.Parse(operand) }; // convert the string to its equivalent decimal.
            textDisplay.Text = textDisplay.Text + "+";
        }



        private void buttonPI_Click(object sender, RoutedEventArgs e)
        {
            textDisplay.Text = "π";
        }

        private void buttonE_Click(object sender, RoutedEventArgs e)
        {
            @operator = new PI { Math.PI };
            textDisplay.Text = "e";
        }



        /*private void buttonSub_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            buttonDisplay.Text = "0";
        }

        private void buttonTimes_Click(object sender, RoutedEventArgs e)
        {
            operation = "x";
            buttonDisplay.Text = "0";
        }

        private void buttonDiv_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            buttonDisplay.Text = "0";
        }

        private void buttonPercent_Click(object sender, RoutedEventArgs e)
        {
            operation = "%";
            buttonDisplay.Text = (number1 / 100).ToString();
        }

        private void buttonPar_Click(object sender, RoutedEventArgs e)
        {
            operation = "( )";
            buttonDisplay.Text = 0;
        }

        

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            buttonDisplay.Text = "0";
        }

        private void buttonBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 / 10);
                buttonDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 / 10);
                buttonDisplay.Text = number2.ToString();
            }
        }*/



    }
}
