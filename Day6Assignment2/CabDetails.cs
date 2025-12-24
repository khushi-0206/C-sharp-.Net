using System;
using System.Diagnostics;
using Day6Assignment2;
public class CabDetails:Cab
{
    public bool ValidateBookingId()
    {
        if (BookingId.Length==6 && BookingId.StartsWith("AC@", StringComparison.Ordinal))
        {
            return true;
        }
        return false;
    }
    public double CalculateFareAmount()
    {
        double watingCharge = Math.Sqrt(WatingTime);
        double fareAmount = 0.0;
        switch (CabType)
        {
            case "Hatchback":
            {
                fareAmount = Distance * 10 + watingCharge;
                break;
            }
            case "Sedan":
            {
                fareAmount = Distance * 20 + watingCharge;
                break;
            }
            case "SUV":
            {
                fareAmount = Distance * 30 + watingCharge;
                break;
            }
            default:
            {
                Console.WriteLine("Invalid Cab type");
                break;
            }
            
        }
        return fareAmount;
    }
}
