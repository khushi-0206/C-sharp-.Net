class Program
{
    public static void Main()
    {
        Console.Write("Enter n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter m: ");
        int m = Convert.ToInt32(Console.ReadLine());

        int count = 0;
        for(int i = n; i <= m; i++)
        {
            if (!isPrime(i))
            {
                int s1 = DigitSum(i);
                int s2 = DigitSum(i * i);
                if(s2 == s1 * s1)
                {
                    count++;
                }
            }
        }
        Console.WriteLine(count);
    }
    static int DigitSum(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            int digit = num%10;
            sum += digit;
            num = num /10;
        }
        return sum;
    }
    static bool isPrime(int num)
    {
        if(num <= 1)
        {
            return false;
        }
        for(int i = 2; i<= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
                
            }
        }
        return true;
    }
    
}