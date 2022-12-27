using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebCalc.Models;
using WebCalc.Operators;

namespace WebCalc.Pages;

[BindProperties]
public class Main : PageModel
{
    public IOperator[] Operators = { new Divide(), new Minus(), new Multiply(), new Plus() };

    public CalculationData CalculationData { get; set; } = new();
    public float? Result;

    public void OnPost()
    {
        var selectedOperation = Operators.First(op => op.GetSign() == CalculationData.Sign);
        Result = selectedOperation.Apply(CalculationData.FirstOperand, CalculationData.SecondOperand);
    }
}