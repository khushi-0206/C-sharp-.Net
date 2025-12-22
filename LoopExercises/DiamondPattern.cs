using System;

namespace LoopStatements;

public class DiamondPattern
{
    public static void PrintDiamondPattern()
    {
        Console.Write("Enter number of rows: ");
        int rows = Int32.Parse(Console.ReadLine());

        //first half
        for(int i=1;i<=rows;i++)
        {
            //for spaces
            for(int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }
            //for printing stars
            for(int k = 1; k <= i; k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        //second half
        for(int i = rows; i >= 0; i--)
        {
            //for spaces
            for(int j = rows-i; j >=1; j--)
            {
                Console.Write(" ");
            }
            //for printing star
            for(int k = i; k > 0; k--)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
