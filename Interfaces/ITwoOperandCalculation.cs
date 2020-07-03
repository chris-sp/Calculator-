namespace Calculator.Interfaces
{
    interface ITwoOperandCalculation<T> : ICalculation<T>
    {        
        decimal Operand1 { get; set; }
        decimal Operand2 { get; set; }
    }
}
