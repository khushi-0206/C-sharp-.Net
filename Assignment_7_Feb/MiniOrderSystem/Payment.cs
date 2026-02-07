public class Payment
{
    public static void MakePayment(decimal amount)
    {
        if (amount <= 0)
        {
            throw new PaymentFailedException();
        }
        Console.WriteLine($"Payment of ${amount} successful.");
    }
}