using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandOne
{
    class Sin : CalculationBase, IOneOperandCalculation<decimal>
    {
        protected override string CalculationName => "Sin";

        public decimal Calculate { get; }
        public decimal Operand { get; set; }

        public double Sine(double a)
        {
            return Convert.ToDecimal(Math.Sin(Convert.ToDouble(Operand)));
        }
    }
}
