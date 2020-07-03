using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandOne
{
    class Exp : CalculationBase, IOneOperandCalculation<decimal>
    {
        protected override string CalculationName => "Exp";

        public decimal Calculate { get; }
        public decimal Operand { get; set; }

        public double Exping(double a)
        {
            double exp_calc;
            exp_calc = Math.Exp(a);
            return exp_calc;
        }
    }
}
