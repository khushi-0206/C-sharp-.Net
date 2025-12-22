using System;
using System.Numerics;

namespace LoopExercises;

public class StrongNumber
{
    public static void StrongNumberMain()
    {
        Console.Write("Enter a number: ");
        int num = Int32.Parse(Console.ReadLine());
        int sum = 0;
        int temp = num;
        while (temp > 0)
        {
            int digit = temp%10;
            int fact = Factorial.FindFactorial(digit);
            sum = sum + fact;
            temp = temp/10;
        }
        Console.WriteLine("Sum of factorial of digits: {0}",sum);
        if (num == sum)
        {
            Console.WriteLine("{0} is a strong number",num);
        }
        else
        {
            Console.WriteLine("{0} is not a strong number",num);
        }
        
    }
}
