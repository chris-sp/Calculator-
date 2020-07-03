using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandOne
{
    class Asin : CalculationBase, IOneOperandCalculation<decimal>
    {
        protected override string CalculationName => "Asin";

        public decimal Calculate { get; }
        public decimal Operand { get; set; }

        public double AngleSine(double a)
        {
            double asin_calc;
            asin_calc = Math.Sqrt(a);
            return asin_calc;
        }
    }
}
