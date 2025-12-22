using System;

namespace LoopExercises;

public class BinaryToDecimal
{
    public static void BinaryToDecimalMain()
    {
        Console.Write("Enter a binary number: ");
        string binary = Console.ReadLine();
        int decimalValue = 0;
        int power = 0;
        for(int i = binary.Length - 1; i >= 0; i--)
        {
            int digit = binary[i] - '0';
            decimalValue += digit * (int)Math.Pow(2,power);
            power++;
        }
        Console.WriteLine("Decimal Vslue: "+decimalValue);
    }
}

