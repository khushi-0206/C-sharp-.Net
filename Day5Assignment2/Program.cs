// See https://aka.ms/new-console-template for more information
using Day6Assignment2;
try
{
    
    Cake cake = new Cake();

    Console.Write("Enter the Flavour: ");
    cake.Flavour = Console.ReadLine();

    Console.Write("Enter the quantity in kg: ");
    cake.QuatityInKg = Int32.Parse(Console.ReadLine());

    Console.Write("Enter the Price Per Kg: ");
    cake.PricePerKg = double.Parse(Console.ReadLine());

    cake.CakeOrder();
    Console.WriteLine("Cake order was successful");
    Console.WriteLine("Price after discount is {0}",cake.DiscountedPrice);

}
catch(InvalidFlavourException e)
{
    Console.WriteLine(e.Message);
}
catch(InvalidQuatityException e)
{
    Console.WriteLine(e.Message);
}


