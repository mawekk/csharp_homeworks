namespace WebCalc.Operators;

public class Plus: IOperator
{
    public float Apply(float firstOperand, float secondOperand) => firstOperand + secondOperand;

    public string GetSign() => "+";
}
