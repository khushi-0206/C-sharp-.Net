using System;
using System.Transactions;

namespace ConditionalStatement;

public class ATMWithdrawal
{
    public static void ATMWithdrawalMain()
    {
        Console.Write("Have you inserted the card? (if yes press y else n)");
        char cardInserted = char.Parse(Console.ReadLine());
        Console.Write("Enter you 4-digit Pin: ");
        int pin = Int32.Parse(Console.ReadLine());
        
        if (cardInserted == 'y' || cardInserted == 'Y')
        {
            if (pin == 1234)
            {
                Console.Write("Enter amount you want to withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                if (amount < 10000)
                {
                    Console.Write("Withdrawal successful");
                }
                else
                {
                    Console.Write("Insufficient balance");
                }
            }
            else
            {
                Console.WriteLine("Enter valid pin");
            }
        }
        else
        {
            Console.Write("Please insert you card first");
        }
    }
}
