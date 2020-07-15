using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandOne
{
    class Cos : CalculationBase, IOneOperandCalculation<decimal>
    {
        protected override string CalculationName => "Cos";
                
        public decimal Operand { get; set; }

        public decimal Calculate()
        {
            return Convert.ToDecimal(Math.Cos(Convert.ToDouble(Operand)));
        }
    }
}
