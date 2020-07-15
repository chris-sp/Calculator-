using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandOne
{
    class Acos : CalculationBase, IOneOperandCalculation<decimal>
    {
        protected override string CalculationName => "Acos";
        
        public decimal Operand { get; set; }

        public decimal Calculate()
        {
            return  Convert.ToDecimal(Math.Acos(Convert.ToDouble(Operand));        
        }
    }
}
