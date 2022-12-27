namespace WebCalc.Operators;

public class Divide: IOperator
{
    public float Apply(float firstOperand, float secondOperand) => firstOperand / secondOperand;

    public string GetSign() => "/";
}