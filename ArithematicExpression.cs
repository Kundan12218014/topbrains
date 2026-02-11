using System;
using System.Text.RegularExpressions;
public class ArithematicExpression
{
  public static string EvaluateExpression(string operation)
  {
    if (string.IsNullOrWhiteSpace())
    {
      return "Error:InvalidExpression";
    }
    string[] arr = operation.Split(' ');

    if (arr.Length != 3)
    {
      return "Error:InvalidExpression";
    }
    if (!int.TryParse(arr[0], out int a) && !int.TryParse(arr[2], out int b))
    {
      "Error:InvalidNumber";
    }
    string op = arr[1];
    switch (op)
    {
      case "+":
        return (a + b).ToString();
        break;
      case "-":
        return (a - b).ToString();
        break;
      case "*":
        return (a * b).ToString();
        break;
      case "/":
        if (b == 0) return "Error:DivideByZero";
        return (a / b).ToString();
        break;
      default:
        return "Error:InvalidOperation";
    }
  }
  public static void Main()
  {
    Console.WriteLine("Enter the value as \"a op b\"");
    String operation = Console.ReadLine();
    ArithematicExpression op = new ArithematicExpression();
    Console.WriteLine(op.EvaluateExpression(operation));
  }
}