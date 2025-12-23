// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices.Marshalling;
using Day5Assingnment;

Console.WriteLine("1. Desktop\n2. Laptop");
Console.Write("Choose the option: ");
int choice = Int32.Parse(Console.ReadLine());

Console.Write("Enter the Processor: ");
string processor = Console.ReadLine();
Console.Write("Enter the ram size: ");
int ramSize = Int32.Parse(Console.ReadLine());
Console.Write("Enter the hard disk size: ");
int hardDisksize = Int32.Parse(Console.ReadLine());
Console.Write("Enter the graphic card size: ");
int graphicCard = Int32.Parse(Console.ReadLine());

if (choice == 1)
{
    Console.Write("Enter monitor size: ");
    int monitorSize = Int32.Parse(Console.ReadLine());
    Console.Write("Enter the power supply volt: ");
    int powerSupplyVolt = Int32.Parse(Console.ReadLine());
    Desktop dObj = new Desktop(processor,ramSize,hardDisksize,graphicCard,monitorSize,powerSupplyVolt);
    double price = dObj.DesktopPriceCalculation();
    Console.WriteLine("Desktop Price is {0}",price);
}
if(choice == 2)
{
    Console.Write("Enter display size: ");
    int displaySize = Int32.Parse(Console.ReadLine());
    Console.Write("Enter the battery volt: ");
    int batteryVolt = Int32.Parse(Console.ReadLine());
    Laptop lObj = new Laptop(processor,ramSize,hardDisksize,graphicCard,displaySize,batteryVolt);
    double price = lObj.LaptopPriceCalculation();
    Console.WriteLine("Laptop Price is {0}",price);
}

