namespace WebCalc.Operators;

public class Minus: IOperator
{
    public float Apply(float firstOperand, float secondOperand) => firstOperand - secondOperand;

    public string GetSign() => "-";
}