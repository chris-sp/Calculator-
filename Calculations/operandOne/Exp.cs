using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandOne
{
    class Exp : CalculationBase, IOneOperandCalculation<decimal>
    {
        protected override string CalculationName => "Exp";
        
        public decimal Operand { get; set; }

        public decimal Calculate()
        {
            return Convert.ToDecimal(Math.Exp(Convert.ToDouble(Operand)));
        }
    }
}
