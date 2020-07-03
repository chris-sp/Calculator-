using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandOne
{
    class Round : CalculationBase, IOneOperandCalculation<decimal>
    {
        protected override string CalculationName => "Round";

        public decimal Calculate { get; }
        public decimal Operand { get; set; }

        public double Rounding(double a)
        {
            double round_calc;
            round_calc = Math.Round(a);
            return round_calc;
        }
    }
}
