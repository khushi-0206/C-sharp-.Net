using System;

namespace LoopExercises;

public class PrimeNumber
{
    public static void CheckPrime()
    {
        Console.Write("Enter a number: ");
        int num = Int32.Parse(Console.ReadLine());
        bool isPrime = true;
        if (num < 2)
        {
            Console.Write("Not Prime");
            return;
        }

        for(int i = 2; i <= Math.Sqrt(num); i++)
        {
            if(num%i==0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {
            Console.Write("{0} is Prime Number",num);
        }
        else
        {
            Console.Write("{0} is not a Prime Number",num);
        }
    }
}
