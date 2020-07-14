using Calculator.Interfaces;
using System;

namespace Calculator.Calculations.operandOne
{
    class Percentage : CalculationBase, IOneOperandCalculation<decimal>
    {
        protected override string CalculationName => "Percentage";

        public decimal Operand { get; set; }

        public decimal Calculate()
        {
            return Operand / 100;
        }
    }
}
