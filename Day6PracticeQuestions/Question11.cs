//Q11
public class SumIntegers
{
    public static void SumIntegersMain()
    {
        object[] values = {10, "abc", true, null, 20, -5};
        int sum = 0;

        foreach(object value in values)
        {
            if(value is int x)
            {
                sum = sum + x;
            }
        }
        Console.WriteLine("Sum: {0}",sum);
    }
}