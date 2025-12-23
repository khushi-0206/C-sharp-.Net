using System;
using System.Dynamic;

namespace Day6Assignment2;

public class Cake
{
    public string Flavour{get; set;}
    public int QuatityInKg{get; set;}
    public double PricePerKg{get; set;}
    
    public double OrderPrice{get; set;}
    public double DiscountedPrice{get; set;}

    public bool CakeOrder()
    {
        if(Flavour == "Chocolate" || Flavour == "Vanilla" || Flavour == "Red velvet")
        {
            if (QuatityInKg > 0)
            {
                OrderPrice = CalculateOrderPrice(QuatityInKg, PricePerKg);
            }
            else
            {
                throw new InvalidQuatityException();
            }
            return true;
        }
        else
        {
            throw new InvalidFlavourException();
        }
    }
    public double CalculateOrderPrice(int QuatityInKg, double PricePerKg)
    {
        OrderPrice =  QuatityInKg * PricePerKg;
        switch (Flavour)
        {
            case "Vanilla":
            {
                DiscountedPrice = OrderPrice - (OrderPrice*3/100);
                break;        
            }
            case "Chocolate":
            {
                DiscountedPrice = OrderPrice - (OrderPrice*5/100);
                break;    
            }
            case "Red velvet":
            {
                DiscountedPrice = OrderPrice - (OrderPrice*10/100);
                break;    
            }
        }
        return DiscountedPrice;
    }

}
