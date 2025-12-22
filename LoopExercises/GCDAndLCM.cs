using System;

namespace LoopExercises;

public class GCDAndLCM
{
    public static void FindGcdAndLcm()
    {
        Console.Write("Enter first number: ");
        int num1 = Int32.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int num2 = Int32.Parse(Console.ReadLine());
        int a = num1;
        int b = num2;
        
        while (b != 0)
        {
            int remainder = a%b;
            a = b;
            b = remainder;
        }
        Console.WriteLine("GCD: {0}",a);
        Console.WriteLine("LCM: {0}",(num1*num2)/a);
    }
}
