using System.Text.RegularExpressions;

public class ShipmentDetails : Shipment
{
    public bool ValidateShipmentCode(string shipmentCode)
    {
        return Regex.IsMatch(shipmentCode, @"^GC#\d{4}$");
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        switch (TransportMode)
        {
            case "Sea":
            {
                totalCost = (weight*15.00) + Math.Sqrt(StorageDays);
                break;

            }
            case "Air":
            {
                totalCost = (weight*50.00) + Math.Sqrt(StorageDays);
                break;

            }
            case "Land":
            {
                totalCost = (weight*25.00) + Math.Sqrt(StorageDays);
                break;

            }
            default: break;
        }
        return Math.Round(totalCost,2);
    }
}