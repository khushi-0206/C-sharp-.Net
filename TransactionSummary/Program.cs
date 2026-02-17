public class ZeroAmountException : Exception
{
    public ZeroAmountException(string message) : base(message)
    {
        
    }
}
public class Program
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        Dictionary<string,int> users = new Dictionary<string, int>();
        try
        {
            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                int amount;
                if(!int.TryParse(input[1],out amount)) continue;

                if(amount == 0) throw new ZeroAmountException("Amount less than 0");

                if (users.ContainsKey(input[0]))
                {
                    users[input[0]] = users[input[0]] + Convert.ToInt32(input[1]);
                }
                else
                {
                    users.Add(input[0],Convert.ToInt32(input[1]));
                }
            }
            if (users.Count == 0)
            {
                Console.WriteLine("No Transactions");
                return;
            }
            var userWithHhgerTransaction = users.OrderByDescending(u => u.Value).ThenBy(u => u.Key).First();
             
            Console.WriteLine(userWithHhgerTransaction.Key);
        }
        catch(ZeroAmountException e)
        {
            Console.WriteLine(e.Message);
        }
    }
    
}