using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandOne
{
    class Log : CalculationBase, IOneOperandCalculation<decimal>
    {
        protected override string CalculationName => "Log";
       
        public decimal Operand { get; set; }

        public decimal Calculate()
        {
            return Convert.ToDecimal(Math.Log(Convert.ToDouble(Operand)));
        }
    }
}
