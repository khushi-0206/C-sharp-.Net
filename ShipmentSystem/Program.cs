using System.Text.Json.Nodes;

class Program
{
    public static void Main()
    {
        ShipmentDetails sObj = new ShipmentDetails();
        System.Console.Write("Input ID: ");
        sObj.ShipmentCode = Console.ReadLine();


        if (sObj.ValidateShipmentCode(sObj.ShipmentCode))
        {
            System.Console.Write("Mode: ");
            sObj.TransportMode = Console.ReadLine();

            System.Console.Write("Weight: ");
            sObj.weight = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("Storage: ");
            sObj.StorageDays = Convert.ToInt32(Console.ReadLine());

            double totalCost = sObj.CalculateTotalCost();
            System.Console.WriteLine($"The total shipping cost is {totalCost:F2}");
        }
        else
        {
            System.Console.WriteLine("Invalid Shipment code");
        }


    }
}