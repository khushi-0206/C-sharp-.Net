using System;

namespace LoopStatements;

public class SumOfDigits
{
    public static void SumOfDigitsMain()
    {
        Console.Write("Enter a number: ");
        int n  = Int32.Parse(Console.ReadLine());
        
        while (n >= 10)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n%10;
                n = n/10;
            }
            n = sum;
        }
        Console.WriteLine("Digital Sum:  {0}",n);
    }
}
