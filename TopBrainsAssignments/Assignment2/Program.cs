using System;
class Program
{
    //using ref
    public static void SwapMe(ref int num1, ref int num2)
    {
        num1 = num1 + num2;
        num2 = num1 - num2;
        num1 = num1 - num2;
    }

    //using ref and out
    public static void SwapMeUsingOut(int num1, int num2, out int swapNum1,out int swapNum2)
    {
        swapNum1 = num2;
        swapNum2 = num1;
    }

    //main method
    public static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Int32.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Numbers Before swapping");
        Console.WriteLine($"num1: {num1}\tnum2: {num2}");

        SwapMe(ref num1,ref num2);

        Console.WriteLine("Numbers After swapping");
        Console.WriteLine($"num1: {num1}\tnum2: {num2}");

        SwapMeUsingOut(num1, num2, out num1,out num2);

        Console.WriteLine("Numbers After Swapping using out");
        Console.WriteLine($"num1: {num1}\tnum2: {num2}");
    }
}