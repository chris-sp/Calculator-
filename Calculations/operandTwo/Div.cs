using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandTwo
{
    class Div : CalculationBase, ITwoOperandCalculation<decimal>
    {
        protected override string CalculationName => "Dividing";
        
        public decimal Operand1 { get; set; }
        public decimal Operand2 { get; set; }

        public decimal Calculate()
        {
            return Operand1 / Operand2;
        }
    }
}
