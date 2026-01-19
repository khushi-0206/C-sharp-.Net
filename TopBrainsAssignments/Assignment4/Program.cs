using System;

class Program
{
    public static void Main()
    {
        Console.Write("Enter Expression: {n1 op n2}: ");
        string expression = Console.ReadLine();

        string result = EvaluateExpression(expression);
        Console.WriteLine(result);
        
    }
    public static string EvaluateExpression(string expression)
    {
        if (string.IsNullOrWhiteSpace(expression))
        {
            return "Error: InvalidExpression";
        }
        
        string[] parts = expression.Split(" ");

        if (parts.Length != 3)
        {
            return "Error: InvalidExpression";
        }

        string num1 = parts[0];
        string op = parts[1];
        string num2 = parts[2];

        if (!int.TryParse(num1, out int a) || !int.TryParse(num2, out int b))
        {
            return "Error: InvalidNumbers";
        }

        switch (op)
        {
            case "+":
                return (a + b).ToString();

            case "-":
                return (a - b).ToString();

            case "*":
                return (a * b).ToString();

            case "/":
                if (b == 0)
                    return "Error:DivideByZero";
                return (a / b).ToString();
            default:
                return "Error: UnknownOperator";
        }
            
    }
}