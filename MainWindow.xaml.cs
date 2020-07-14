using Calculator.Calculations.operandOne;
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


        // NUMBERS //
        private void button0_Click(object sender, RoutedEventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "0";
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


        // TWO OPERAND MATHS //
        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            @operator = new Addition { Operand1 = Decimal.Parse(operand) }; // convert the string to its equivalent decimal.
            textDisplay.Text = textDisplay.Text + "+";
        }

        private void buttonSub_Click(object sender, RoutedEventArgs e)
        {
            @operator = new Substraction { Operand1 = Decimal.Parse(operand) }; // convert the string to its equivalent decimal.
            textDisplay.Text = textDisplay.Text + "-";
        }

        private void buttonTimes_Click(object sender, RoutedEventArgs e)
        {
            @operator = new Multiply { Operand1 = Decimal.Parse(operand) };
            textDisplay.Text = textDisplay.Text + "×";
        }

        private void buttonDiv_Click(object sender, RoutedEventArgs e)
        {
            @operator = new Div { Operand1 = Decimal.Parse(operand) };
            textDisplay.Text = textDisplay.Text + "/";
        }

        private void buttonPercent_Click(object sender, RoutedEventArgs e)
        {
            @operator = new Percentage { Operand = Decimal.Parse(operand) };
            textDisplay.Text = textDisplay.Text + "%";
        }
        private void textMod_Click(object sender, RoutedEventArgs e)
        {
            @operator = new Mod { Operand1 = Decimal.Parse(operand) };
            textDisplay.Text = "mod(" + textDisplay.Text + "," + textDisplay + ")";
        }

        private void textPower_Click(object sender, RoutedEventArgs e)
        {
            @operator = new Power { Operand1 = Decimal.Parse(operand) };
            textDisplay.Text = textDisplay.Text + "^";
        }


        // NO OPERAND MATHS //
        private void buttonPI_Click(object sender, RoutedEventArgs e)
        {
            textDisplay.Text = "π";
        }

        private void buttonE_Click(object sender, RoutedEventArgs e)
        {
            textDisplay.Text = "e";
        }


        // CLEAR BUTTONS // 
        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            textDisplay.Text = "";
        }

        private void buttonBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (operand == "")                                                                  //////////////////////////////////////////////////////////////////////////
            {                                                                                   //  Here we use the method Remove(),                                    //
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1);       //  and use it to Display the length of the text                        //
                                                                                               //  decreased/removed by one(-1) --> ( text.Display.Text.Length - 1 );  //
            }                                                                                   //////////////////////////////////////////////////////////////////////////
            else if (textDisplay.Text.Length > 0)
            {
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1);
            }
        }


        // SYMBOLS //
        private void buttonDec_Click(object sender, RoutedEventArgs e)
        {
            if (textDisplay.Text == ".")
            {
                if (!textDisplay.Text.Contains("."))
                {
                    textDisplay.Text = textDisplay.Text + textDisplay.Text;
                }
                else
                {
                    textDisplay.Text = textDisplay.Text + textDisplay.Text;
                }
            }
        }

        private void buttonEquals_Click(object sender, RoutedEventArgs e)
        {
            /*  THERE IS ALSO THIS WAY TO CONVERT SOMETHING TO DECIMAL  
             * 
             *  decimal decimalValue;
             *  decimalValue = System.Convert.ToDecimal(stringVal);     
             */          

            if (@operator is IOneOperandCalculation<decimal> oneOperation)
            {
                decimal one_value = oneOperation.Calculate();
                textDisplay.Text = textDisplay.Text + "=" + one_value.ToString();

            }

            if (@operator is ITwoOperandCalculation<decimal> twoOperation)
            {
                twoOperation.Operand2 = Decimal.Parse(operand);
                decimal two_value = twoOperation.Calculate();
                textDisplay.Text = textDisplay.Text + "=" + two_value.ToString();
            }
        }
    }
}
