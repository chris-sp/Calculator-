using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandOne
{
    class Ceiling : CalculationBase, IOneOperandCalculation<decimal>
    {
        protected override string CalculationName => "Ceiling";
                
        public decimal Operand { get; set; }

        public decimal Calculate()
        {
            return Convert.ToDecimal(Math.Ceiling(Convert.ToDouble(Operand)));
        }
    }
}
