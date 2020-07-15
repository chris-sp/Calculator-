using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandOne
{
    class Floor : CalculationBase, IOneOperandCalculation<decimal>
    {
        protected override string CalculationName => "Floor";
        
        public decimal Operand { get; set; }

        public decimal Calculate()
        {
            return Convert.ToDecimal(Math.Floor(Convert.ToDouble(Operand)));
        }
    }
}
