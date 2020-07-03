namespace Calculator.Interfaces
{
    interface IOneOperandCalculation<T> : ICalculation<T>
    {
        decimal Operand { get; set; }
    }
}
