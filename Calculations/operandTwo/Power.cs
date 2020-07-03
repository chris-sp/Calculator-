using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandTwo
{
    class Power : CalculationBase, ITwoOperandCalculation<decimal>
    {
        protected override string CalculationName => "Power";

        public decimal Operand1 { get; set; }
        public decimal Operand2 { get; set; }
        public decimal Calculate { get; }

        public int Powering(double a, double b)
        {
            double value = a;
            double power = b;
            int pow; 
            pow = Convert.ToInt32(Math.Pow(value, power));
            return pow;
        }        
    }
}
