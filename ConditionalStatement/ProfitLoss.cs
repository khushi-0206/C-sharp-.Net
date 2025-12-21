using System;

namespace ConditionalStatement;

public class ProfitLoss
{
    public static void ProfitLossMain()
    {
        Console.Write("Enter Cost price of product: ");
        int costPrice = Int32.Parse(Console.ReadLine());
        Console.Write("Enter selling Price of Product: ");
        int sellingPrice = Int32.Parse(Console.ReadLine());
        double profitOrLoss = sellingPrice - costPrice;
        if(profitOrLoss < 0)
        {
            Console.Write("Loss of {0} %",(Math.Abs(profitOrLoss)/costPrice)*100);
        }
        else if(profitOrLoss==0)
        {
            Console.Write("No Loss No Profit");
        }
        else
        {
            Console.Write("Profit of {0} %",(profitOrLoss/costPrice)*100);
        }
    }
}
