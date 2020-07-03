using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandNo
{
    class E : CalculationBase, INoOperandCalculation<decimal>
    {
        protected override string CalculationName => "E";
        
        public decimal Calculate()
        {
            return (decimal)Math.E;
        }
    }
}
