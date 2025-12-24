//Q9
public class GCD{
    public static int FindGCD(int a, int b)
    {
        if (b == 0)
        return a;
        return FindGCD(b, a % b);
    }
    public static void GCDMain()
    {
        System.Console.Write("Enter First Number: ");
        int a = int.Parse(Console.ReadLine());

        System.Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());
        
        Console.WriteLine(FindGCD(a, b));
    }
}