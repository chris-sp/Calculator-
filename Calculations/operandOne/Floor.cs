using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Calculations.operandOne
{
    class Floor : CalculationBase, IOneOperandCalculation<decimal>
    {
        protected override string CalculationName => "Floor";

        public decimal Calculate { get; }
        public decimal Operand { get; set; }

        public double Flooring(double a)
        {
            double floor_calc;
            floor_calc = Math.Floor(a);
            return floor_calc;
        }
    }
}
