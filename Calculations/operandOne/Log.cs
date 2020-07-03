using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandOne
{
    class Log : CalculationBase, IOneOperandCalculation<decimal>
    {
        protected override string CalculationName => "Log";

        public decimal Calculate { get; }
        public decimal Operand { get; set; }

        public double Logging(double a)
        {
            double log_calc;
            log_calc = Math.Log(a);
            return log_calc;
        }
    }
}
