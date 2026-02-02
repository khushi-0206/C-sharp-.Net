class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the number of gadget entities: ");
        int gadgets = Int32.Parse(Console.ReadLine());

        for(int i = 0; i < gadgets; i++)
        {
            try
            {
                Console.WriteLine($"Enter gadget {i+1} details");
                String gadget = Console.ReadLine();
                String[] details = gadget.Split(":");

                GadgetValidatorUtil obj = new GadgetValidatorUtil();
                if(obj.validateGadgetId(details[0])&& obj.validateWarrantyPeriod(Convert.ToInt32(details[2])))
                {
                    Console.WriteLine("Warranty accepted,stock updated");
                }
                
            }
            catch(InvalidGadgetExcetion e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}