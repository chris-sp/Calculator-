using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandOne
{
    class Acos : CalculationBase, IOneOperandCalculation<decimal>
    {
        protected override string CalculationName => "Acos";

        public decimal Calculate { get; }
        public decimal Operand { get; set; }

        public double AngleCosine(double a)
        {
            double acos_calc;
            acos_calc = Math.Sqrt(a);
            return acos_calc;
        }
    }
}
