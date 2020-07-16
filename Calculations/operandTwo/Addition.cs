using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandTwo
{
    class Addition : CalculationBase, ITwoOperandCalculation<decimal>
    {
        //------------------------------------------>same as { get{return "Add";} }
        protected override string CalculationName => "Addition";
        
        public decimal Operand1 { get; set; }
        public decimal Operand2 { get; set; }

        public decimal Calculate()
        {     
            return Operand1 + Operand2;
        }
    }
}
