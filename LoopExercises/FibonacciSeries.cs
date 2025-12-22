using System;

namespace LoopStatements;

public class FibonacciSeries
{
    public static void PrintFibonaaci()
    {
        Console.Write("Enter a number till you want to find fibonacci: ");
        int num = Int32.Parse(Console.ReadLine());
        int firstNum = 0;
        int secondNum = 1;
        Console.Write("Fibonacci Series: ");
        if (num >= 1)
        {
            Console.Write(firstNum+" ");
        }
        if (num >= 2)
        {
            Console.Write(secondNum+" ");
        }
        for(int i = 2; i <= num; i++)
        {
            int temp = firstNum + secondNum;
            Console.Write(temp+" ");
            firstNum = secondNum;
            secondNum = temp;
        }
    }
}
