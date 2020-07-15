using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandOne
{
    class Sqrt : CalculationBase, IOneOperandCalculation<decimal>
    {
        protected override string CalculationName => "Square";
        
        public decimal Operand { get; set; }

        public decimal Calculate()
        {
            return Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(Operand)));
        }
    }
}
