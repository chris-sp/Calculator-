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
                
        public decimal Operand { get; set; }

        public decimal Calculate()
        {
            return Convert.ToDecimal(Math.Atan(Convert.ToDouble(Operand)));
        }
    }
}
