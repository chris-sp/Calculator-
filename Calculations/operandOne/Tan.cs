using Calculator.Interfaces;
using System;

namespace Calculator.Calculations.operandOne
{
    class Tan : CalculationBase, IOneOperandCalculation<decimal>
    {
        protected override string CalculationName => "Tan";

        public decimal Operand { get; set; }

        public decimal Calculate()
        {
            return Convert.ToDecimal(Math.Tan(Convert.ToDouble(Operand)));
        }        
    }
}
