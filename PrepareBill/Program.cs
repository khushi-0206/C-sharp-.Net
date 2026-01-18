using System;
class Program
{
    public static void Main()
    {
        PrepareBill bill = new PrepareBill();
        bill.SetTaxRates(CommodityCategory.Furniture, 0.10);
        bill.SetTaxRates(CommodityCategory.Grocery,0.05);
        bill.SetTaxRates(CommodityCategory.Service,0.12);

        List<Commodity> commodities = new List<Commodity>();
        try
        {
            
        
            Console.Write("Enter number of commodities: ");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nCommodity {i + 1}");

                Console.Write("Enter commodity name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Select category:");
                foreach (CommodityCategory cat in Enum.GetValues(typeof(CommodityCategory)))
                {
                    Console.WriteLine($"{(int)cat} - {cat}");
                }

                CommodityCategory category =
                    (CommodityCategory)Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter quantity: ");
                int qty = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                commodities.Add(new Commodity(category, name, qty, price));
            }

            double total = bill.CalculateBillAmount(commodities);
            Console.WriteLine(total);
        }
        catch(ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}