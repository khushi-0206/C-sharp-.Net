class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the number of entities: ");
        int entries = Int32.Parse(Console.ReadLine());

        for(int i = 0; i < entries; i++)
        {
            try
            {
                Console.WriteLine($"Enter entry {i+1} details");
                String entry = Console.ReadLine();
                String[] details = entry.Split(":");

                EntryUtility obj = new EntryUtility();
                if(obj.ValidateEmployeeId(details[0])&& obj.ValidateDuration(Convert.ToInt32(details[2])))
                {
                    Console.WriteLine("Valid entry details");
                }
                
            }
            catch(InvalidEntryException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}