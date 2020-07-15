using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandOne
{
    class Sin : CalculationBase, IOneOperandCalculation<decimal>
    {
        protected override string CalculationName => "Sine";
        
        public decimal Operand { get; set; }

        public decimal Calculate()
        {
            return Convert.ToDecimal(Math.Sin(Convert.ToDouble(Operand)));
        }
    }
}
