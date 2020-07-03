using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandTwo
{
    class Mod : CalculationBase, ITwoOperandCalculation<decimal>
    {
        protected override string CalculationName => "Mod";

        public decimal Calculate { get; }
        public decimal Operand1 { get; set; }
        public decimal Operand2 { get; set; }

        public int Modulo(int a, int b)
        {
            int number_a = a;
            int number_b = b;
            int rem;
            rem = number_a % number_b;
            return rem;
        }
    }
}
