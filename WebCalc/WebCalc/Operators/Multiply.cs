namespace WebCalc.Operators;

public class Multiply: IOperator
{
    public float Apply(float firstOperand, float secondOperand) => firstOperand * secondOperand;

    public string GetSign() => "*";
}