using Calculator.Interfaces;
using System;

namespace Calculator.Calculations.operandOne
{
    class Tan : CalculationBase, IOneOperandCalculation<decimal>
    {
        protected override string CalculationName => "Tan";

        public decimal Calculate { get; }
        public decimal Operand { get; set; }

        public double Tangent(double a)
        {
            double tan_calc;
            tan_calc = Math.Tan(a);
            return tan_calc;
        }        
    }
}
