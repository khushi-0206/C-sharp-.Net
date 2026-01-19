using System;
class Program
{
    public static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int largestNumber = FindLargestOfThree(num1,num2,num3);

        Console.WriteLine($"Largest of {num1}, {num2} and {num3} is {largestNumber}");
    }
    public static int FindLargestOfThree(int a, int b, int c)
    {
        if(a>b && a > c)
        {
            return a;
        }
        else if(b>a && b > c)
        {
            return b;
        }
        else
        {
            return c;
        }
    }
}