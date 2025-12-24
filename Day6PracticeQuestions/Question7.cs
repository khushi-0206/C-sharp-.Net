//Q7

public class MultiplicationTable
{
    public static void PrintTable()
    {
        System.Console.Write("Enter a number: ");
        int num = Int32.Parse(Console.ReadLine());

        System.Console.Write("Up to which: ");
        int upTo = Int32.Parse(Console.ReadLine());

        for(int i = 1; i <= upTo; i++)
        {
            Console.Write(num*i +" ");
        }
    }
}