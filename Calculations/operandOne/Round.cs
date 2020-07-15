using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandOne
{
    class Round : CalculationBase, IOneOperandCalculation<decimal>
    {
        protected override string CalculationName => "Round";
        
        public decimal Operand { get; set; }

        public decimal Calculate()
        {
            return Convert.ToDecimal(Math.Round(Operand));
        }
    }
}
