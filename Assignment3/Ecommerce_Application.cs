using System;

class EcommerceShop
{
    public string UserName{get;set;}
    public double WalletBalance{get;set;}
    public double TotalPurchaseAmount{get;set;}

}
class Program
{
    public static void Main()
    {
        
        try
        {
            Console.WriteLine("Enter User Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Wallet Balance:");
            double balance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Purchase Amount:");
            double amount = Convert.ToDouble(Console.ReadLine());

            Program p = new Program();
            EcommerceShop shop = p.MakePayment(name, balance, amount);

            Console.WriteLine("Payment successful");
        }catch(InsufficientBalanceException e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public EcommerceShop MakePayment(string name, double balance, double amount)
    {
        if(balance < amount)
        {
            throw new InsufficientBalanceException("Insufficient balance in your digital wallet");
        }
        EcommerceShop esObj = new EcommerceShop
        {
            UserName = name,
            WalletBalance = balance,
            TotalPurchaseAmount = amount
        };
        return esObj;
    }
}
class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException()
    {
        
    }
    public InsufficientBalanceException(string message) : base(message)
    {
        
    }
}