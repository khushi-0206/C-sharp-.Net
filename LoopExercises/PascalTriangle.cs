using System;

namespace LoopExercises;

public class PascalTriangle
{
    public static void PrintPascalTriangle()
    {
        Console.Write("Enter number of rows: ");
        int rows = Int32.Parse(Console.ReadLine());
        for(int i = 0; i < rows; i++)
        {
            int value = 1;
            for(int j = 0; j <= i; j++)
            {
                Console.Write(value+" ");
                value = value * (i-j)/(j+1);
            }
            Console.WriteLine();
        }
    }
}
