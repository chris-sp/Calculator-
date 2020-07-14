using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandNo
{
    class PI : CalculationBase, INoOperandCalculation<decimal>
    {
        protected override string CalculationName => "PI";

        public decimal Calculate()
        {
            return Convert.ToDecimal(Math.PI);
        }        
    }
}

