using System;
class Program
{
    public static void Main()
    {
        Console.Write("Enter number: ");
        int n = Int32.Parse(Console.ReadLine());

        Console.Write("Upto which number: ");
        int upto = Int32.Parse(Console.ReadLine());

        int[] result = MultiplicationTable(n,upto);
        for(int i = 0; i < result.Length; i++)
        {
            if (i != result.Length - 1)
            {
                Console.Write(result[i]+",");
            }
            else
            {
                Console.Write(result[i]);   
            }
        }
    }

    public static int[] MultiplicationTable(int n, int upto)
    {
        int[] table = new int[upto];

        for(int i = 0; i < upto; i++)
        {
            table[i] = n * (i+1);
        }
        return table;
    }
}