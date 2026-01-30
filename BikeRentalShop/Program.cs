class Program
{
    public static SortedDictionary<int, Bike> bikeDetails = new SortedDictionary<int, Bike>();
    public static void Main()
    {
        BikeUtility buObj = new BikeUtility();
        while (true)
        {
            Console.WriteLine("1. Add Bike Details");
            Console.WriteLine("2. Group Bikes By Brand");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
            Console.Write("Enter ypu choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                {
                    Console.Write("Enter the model: ");
                    string model = Console.ReadLine();

                    Console.Write("Enter the brand: ");
                    string brand = Console.ReadLine();

                    Console.Write("Enter the price per day: ");
                    int pricePerDay = Convert.ToInt32(Console.ReadLine());

                    buObj.AddBikeDetails(model,brand,pricePerDay);
                    Console.WriteLine("Bike details added successfully");

                    break;
                }
                case 2:
                {
                    var group = buObj.GroupBikesByBrand();
                    foreach(var brand in group)
                    {
                        Console.WriteLine(brand.Key);
                        foreach(var bike in brand.Value)
                        {
                            Console.WriteLine(bike.Model);            
                        }
                        Console.WriteLine();

                    }
                    break;
                        
                }
                case 3:
                {
                    return;
                }
                default:
                {
                    Console.WriteLine("Invalid Choice");
                    break;
                }
            }
        }
    }

}