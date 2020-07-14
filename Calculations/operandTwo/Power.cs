using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandTwo
{
    class Power : CalculationBase, ITwoOperandCalculation<decimal>
    {
        protected override string CalculationName => "Power";

        public decimal Operand1 { get; set; }
        public decimal Operand2 { get; set; }        

        public decimal Calculate()
        {            
            return Convert.ToDecimal(Math.Pow(Convert.ToDouble(Operand1), Convert.ToDouble(Operand2)));
        }        
    }
}
