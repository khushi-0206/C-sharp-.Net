class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter Consultant Type (1 = In-House, 2 = Visiting): ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter Consultant ID: ");
            string id = Console.ReadLine();

            Consultant consultant;

            if (choice == 1)
            {
                Console.Write("Enter Monthly Stipend: ");
                double stipend = double.Parse(Console.ReadLine());

                Console.Write("Enter Allowances: ");
                double allowances = double.Parse(Console.ReadLine());

                Console.Write("Enter Bonus: ");
                double bonus = double.Parse(Console.ReadLine());

                consultant = new InHouseConsultant(id, stipend, allowances, bonus);
            }
            else if (choice == 2)
            {
                Console.Write("Enter Number of Visits: ");
                int visits = int.Parse(Console.ReadLine());

                Console.Write("Enter Rate per Visit: ");
                double rate = double.Parse(Console.ReadLine());

                consultant = new VisitingConsultant(id, visits, rate);
            }
            else
            {
                Console.WriteLine("Invalid choice");
                return;
            }

            DisplayPayout(consultant);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void DisplayPayout(Consultant consultant)
    {
        double gross = consultant.CalculateGrossPayout();
        double tdsRate = consultant.CalculateTDS(gross);
        double net = gross - (gross * tdsRate);

        Console.WriteLine("\n--- Payout Summary ---");
        Console.WriteLine($"Gross: {gross:F2}");
        Console.WriteLine($"TDS Applied: {tdsRate * 100}%");
        Console.WriteLine($"Net Payout: {net:F2}");
    }
}
