using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandOne
{
    class Sqrt : CalculationBase, IOneOperandCalculation<decimal>
    {
        protected override string CalculationName => "Square";


        public decimal Calculate { get; }
        public decimal Operand { get; set; }

        public double Square(double a)
        {
            double sqrt_calc;
            sqrt_calc = Math.Sqrt(a);
            return sqrt_calc;
        }
    }
}
