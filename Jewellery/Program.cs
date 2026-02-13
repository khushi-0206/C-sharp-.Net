class Program
{
    public static Dictionary<string, Jewellery> jewelleryDetails = new Dictionary<string, Jewellery>();
    public static void Main()
    {
        jewelleryDetails.Add("JW01",new Jewellery(){ID = "JW01",Type = "Bracelet",Material = "Silver",Price = 8000});
        jewelleryDetails.Add("JW02",new Jewellery(){ID = "JW02",Type = "Ring",Material = "Diamond",Price = 100000});
        jewelleryDetails.Add("JW03",new Jewellery(){ID = "JW03",Type = "Necklace",Material = "Gold",Price = 70000});

        
        do
        {
            System.Console.WriteLine("1.Get Jewellery Details");
            System.Console.WriteLine("2. Update Price");
            System.Console.WriteLine("3. Exit");

            System.Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                {
                    JewelleryUtility juObj = new JewelleryUtility();
                    System.Console.WriteLine("Enter jewellery Id: ");
                    string id = Console.ReadLine();
                    Dictionary<string,string> details = juObj.GetJewelleryDetails(id);
                    if(details != null)
                    {
                        foreach(var detail in details)
                        {
                            System.Console.WriteLine($"{detail.Key} {detail.Value}");          
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("Jewellery Id not found");   
                    }
                    break;
                }
                case 2:
                {
                    JewelleryUtility juObj = new JewelleryUtility();
                    System.Console.WriteLine("Enter id: ");
                    string id = Console.ReadLine();
                    System.Console.WriteLine("Enter price to be updated: ");
                    int price = Convert.ToInt32(Console.ReadLine());

                    Dictionary<string,Jewellery> res = juObj.UpdateJewelleryPrice(id,price);
                    if(res != null)
                    {
                        foreach(var item in res.Values)
                        {
                            
                            System.Console.WriteLine($"Id: {item.ID}, Type: {item.Type}, Material: {item.Material}, Price: {item.Price}");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("Jewellery id not found");
                    }
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Exiting..");
                    return;
                }
                default:
                {
                    System.Console.WriteLine("Invalid chocie..");
                  break;  
                }
            }
        }
        while(true);
        
    }
}