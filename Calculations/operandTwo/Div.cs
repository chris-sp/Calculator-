using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandTwo
{
    class Div : CalculationBase, ITwoOperandCalculation<decimal>
    {
        protected override string CalculationName => "Dividing";

        public decimal Calculate { get; }
        public decimal Operand1 { get; set; }
        public decimal Operand2 { get; set; }

        public int Divi(int a, int b)
        {
            int number_a = a;
            int number_b = b;
            int quot;
            quot = number_a / number_b;
            return quot;
        }
    }
}
