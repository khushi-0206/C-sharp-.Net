class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter Deluxe Roon Details: ");
        Console.Write("Guest Name: ");
        string dName = Console.ReadLine();

        Console.Write("Rate per Night: ");
        double dRatePerNight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nights Stayed: ");
        int dNightsStayed = Convert.ToInt32(Console.ReadLine());

        Console.Write("Joining Year: ");
        int dJoiningYear = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Suite Roon Details: ");
        Console.Write("Guest Name: ");
        string sName = Console.ReadLine();

        Console.Write("Rate per Night: ");
        double sRatePerNight2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nights Stayed: ");
        int sNightsStayed2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Joining Year: ");
        int sJoiningYear2 = Convert.ToInt32(Console.ReadLine());
        
        HotelRoom deluxe = new HotelRoom("Deluxe",dRatePerNight,dName);
        deluxe.DisplaySummary(dJoiningYear);

        HotelRoom suite = new HotelRoom("Suite",sRatePerNight2,dName);
        suite.DisplaySummary(sJoiningYear2);

        Console.WriteLine("Total Bill: ");
        

        Console.WriteLine($"For {dName} (Deluxe): {deluxe.CalculateTotalBill(dNightsStayed,dJoiningYear):F1}");
        Console.WriteLine($"For {sName} (Suite): {suite.CalculateTotalBill(sNightsStayed2,sJoiningYear2):F1}");

    }
}