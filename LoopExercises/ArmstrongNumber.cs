using System;

namespace LoopStatements;

public class ArmstrongNumber
{
    public static void CheckArmstrong()
    {
        Console.Write("Enter a number: ");
        int num = Int32.Parse(Console.ReadLine());
        int temp = num;
        int count = countOfDigit(temp);
        double sum = 0;
        while (temp > 0)
        {
            int digit = temp%10;
            sum +=  Math.Pow(digit,count);
            temp = temp/10;
        }
        Console.WriteLine("Original number: {0}",num);
        Console.WriteLine("Sum: {0}",sum);
        if (sum == num)
        {
            Console.WriteLine("Number is Armstrong");
        }
        else
        {
            Console.WriteLine("Number is not Armstrong");
        }
    }
    public static int countOfDigit(int temp)
    {
        int count = 0;
        while (temp > 0)
        {
            temp = temp/10;
            count++;
        }
        return count;
    }
}
