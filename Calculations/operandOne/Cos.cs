using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandOne
{
    class Cos : CalculationBase, IOneOperandCalculation<decimal>
    {
        protected override string CalculationName => "Cos";

        public decimal Calculate { get; }
        public decimal Operand { get; set; }

        public double Cosine(double a)
        {
            double cos_calc;
            cos_calc = Math.Sqrt(a);
            return cos_calc;
        }
    }
}
