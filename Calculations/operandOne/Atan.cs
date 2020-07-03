using Calculator.Interfaces;
using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandOne
{
    class Atan : CalculationBase, IOneOperandCalculation<decimal>
    {
        protected override string CalculationName => "Atan";

        public decimal Calculate { get; }
        public decimal Operand { get; set; }

        public double AngleTangent(double a)
        {
            double atan_calc;
            atan_calc = Math.Atan(a);
            return atan_calc;
        }
    }
}
