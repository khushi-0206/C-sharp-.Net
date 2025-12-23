// See https://aka.ms/new-console-template for more information
using System.Data;
using Day5Assignment3;

Candy cObj = new Candy();

Console.Write("Enter the flavour: ");
cObj.Flavour = Console.ReadLine();

Console.Write("Enter Quantity: ");
cObj.Quantity = Int32.Parse(Console.ReadLine());

Console.Write("Enter the price per piece: ");
cObj.PricePerPiece = Int32.Parse(Console.ReadLine());

if (cObj.ValidateCandyFlavour())
{
    
    Candy c = CalculateDiscountedPrice(cObj);
    Console.WriteLine($"Flavour: {cObj.Flavour}");
    Console.WriteLine($"Quantity: {cObj.Quantity}");
    Console.WriteLine($"Price Per Peice: {cObj.PricePerPiece}");
    Console.WriteLine($"Total Price: {cObj.TotalPrice}");
    Console.WriteLine($"Discount Price: {cObj.Discount}");
}
else
{
    Console.WriteLine("Invalid flavour");
}

Candy CalculateDiscountedPrice(Candy candy)
{
    candy.TotalPrice = candy.Quantity * candy.PricePerPiece;
    switch (candy.Flavour)
    {
        case "Strawberry":
        {
            candy.Discount = candy.TotalPrice - (candy.TotalPrice * 15/100);
            break;
        }
        case "Lemon":
        {
            candy.Discount = candy.TotalPrice - (candy.TotalPrice * 10/100);
            break;    
        }
        case "Mint":
        {
            candy.Discount = candy.TotalPrice - (candy.TotalPrice * 5/100);
            break; 
        }
    }
    return candy;
}
