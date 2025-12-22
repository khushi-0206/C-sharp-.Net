using System;
using System.Numerics;

namespace LoopExercises;

public class Factorial
{
    public static void FindFactorial()
    {
        Console.Write("Enter a number: ");
        int n = Int32.Parse(Console.ReadLine());
        BigInteger fact = 1;
        for(int i = 1; i <= n; i++)
        {
            fact = fact * i;
        }
        Console.WriteLine("factorial is: {0}",fact);
    }
    public static int FindFactorial(int digit)
    {
        int fact = 1;
        for(int i = 1; i <= digit; i++)
        {
            fact = fact * i;
        }
        return fact;
    }
}
