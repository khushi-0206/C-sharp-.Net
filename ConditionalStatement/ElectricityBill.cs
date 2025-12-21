using System;

namespace ConditionalStatement;

public class ElectricityBill
{
    public static void CalculateElectricityBill()
    {
        Console.Write("Enter units: ");
        double units = double.Parse(Console.ReadLine());
        double bill = 0.0;
        if(units>=1 && units <= 199)
        {
            bill = units * 1.20;
            
        }
        else if(units>=200 && units <400)
        {
            bill = units * 1.50;
        }
        else if(units>=400 && units <= 600)
        {
            bill = units * 1.80;
        }
        else
        {
            bill = units * 2;
        }
        if (bill > 400)
        {
            bill = bill + (bill*15/100);
        }
        Console.WriteLine("Your electricity bill: {0}",bill);
    }
}
