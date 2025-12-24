//Q8

using System.Reflection.Metadata;

public class Main
{
    public static void SumValues()
    {
        System.Console.WriteLine("Enter values: ");
        string[] tokens = Console.ReadLine().Split(' ');
        int sum = 0;

        foreach (string token in tokens)
        {
            if (int.TryParse(token, out int value))
            {
                sum = sum + value;
            }
        }

        Console.WriteLine("Sum: {0}",sum);
    }
}