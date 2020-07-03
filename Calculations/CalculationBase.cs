using Calculator.Calculations.operandTwo;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Calculator.Calculations
{
    abstract class CalculationBase
    {
        protected abstract string CalculationName { get; }
        public string GetCalculationDescription()
        {
            return $"This is {CalculationName}";
        }      
        
    }
}
