using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandOne
{
    class Abs : CalculationBase, IOneOperandCalculation<decimal>
    {
        protected override string CalculationName => "Abs";
        
        public decimal Operand { get; set; }
        
        public decimal Absolute()
        {
            return Convert.ToDecimal(Math.Abs(Operand));
        }
    }    
}
