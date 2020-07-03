using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandOne
{
    class Ceiling : CalculationBase, IOneOperandCalculation<decimal>
    {
        protected override string CalculationName => "Ceiling";

        public decimal Calculate { get; }
        public decimal Operand { get; set; }

        public double Ceilining(double a)
        {
            double ceiling_calc;
            ceiling_calc = Math.Ceiling(a);
            return ceiling_calc;
        }
    }
}
