using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandOne
{
    class Asin : CalculationBase, IOneOperandCalculation<decimal>
    {
        protected override string CalculationName => "Asin";
       
        public decimal Operand { get; set; }

        public decimal Calculate()
        {
            return Convert.ToDecimal(Math.Asin(Convert.ToDouble(Operand)));
        }
    }
}
