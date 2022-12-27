namespace WebCalc.Operators;

public interface IOperator
{
    float Apply(float firstOperand, float secondOperand);
    string GetSign();
}
