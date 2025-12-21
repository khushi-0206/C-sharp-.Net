using System;

namespace ConditionalStatement;

public class SampleCalculator
{
    public static void SampleCalculatorMain()
    {
        Console.Write("Enter first number: ");
        int num1 = Int32.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int num2 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Operations: \n1.Addition\n2.Subtraction\n3.MultiPlication\n4.Division");
        Console.Write("Enter you choice: ");
        int choice = Int32.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
            {
                Console.WriteLine("Addition of {0} and {1}: {2}",num1,num2,(num1+num2));
                break;   
            }
            case 2:
            {
                Console.WriteLine("Subtraction of {0} and {1}: {2}",num1,num2,(num1-num2));
                break;   
            }
            case 3:
            {
                Console.WriteLine("Multiplication of {0} and {1}: {2}",num1,num2,(num1*num2));
                break;   
            }
            case 4:
            {
                if (num2 == 0)
                {
                    Console.Write("Division by 0 is not possible"); 
                    return;
                }
                Console.WriteLine("Addition of {0} and {1}: {2}",num1,num2,(num1+num2));
                break;   
            }
        }

    }
}
