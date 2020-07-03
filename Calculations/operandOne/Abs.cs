using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandOne
{
    class Abs : CalculationBase, IOneOperandCalculation<decimal>
    {
        protected override string CalculationName => "Abs";

        public decimal Calculate { get; }
        public decimal Operand { get; set; }
        
        public decimal Absolute(decimal a)
        {
            decimal abs_calc = a;
            abs_calc = Math.Abs(a);
            return abs_calc;
        }
    }    
}
