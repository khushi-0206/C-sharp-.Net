//Q10: Simulate a bank account

public class BankAccount
{
    public static void Balance()
    {
        System.Console.Write("Enter initial balance: ");
        int initialBalance = Int32.Parse(Console.ReadLine());

        System.Console.Write("Enter number of transactions: ");
        int n = int.Parse(Console.ReadLine());

        int[] transactions = new int[n];
        for (int i=0; i<n;i++)
        {
            System.Console.Write("Enter tansaction {0}: ",(i+1));
            transactions[i] = int.Parse(Console.ReadLine());
        }
        
        System.Console.WriteLine("Final balance: {0}",FinalBalance(initialBalance,transactions));
    }
    public static int FinalBalance(int initialBalance, int[] transactions)
    {
        int balance = initialBalance;

        foreach (int t in transactions)
        {
            if (t >= 0)
            {
                balance += t; // deposit
            }
            else
            {
                if (balance + t >= 0)
                {
                    balance += t; // withdraw
                }
                // else ignore
            }
        }
        return balance;
    }

}