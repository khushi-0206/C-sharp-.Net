class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter initial balance: ");
        int initialBalance = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number of transactions: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] tranactions = new int[n];
        for(int i = 0; i < n; i++)
        {
            tranactions[i] = Convert.ToInt32(Console.ReadLine());
        }

        int res = SimulateBankAccount(initialBalance, tranactions);
        Console.WriteLine(res);
        
    }
    public static int SimulateBankAccount(int initialBalance, int[] transactions)
    {
        long balance = initialBalance;
        foreach(int t in transactions){
            if(t >= 0)
            {
                balance += t;
            }
            else
            {
                if(balance + t >= 0)
                {
                    balance += t;
                }
            }
        }
        return (int)balance;
    }
}