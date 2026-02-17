using System.Text.RegularExpressions;
public class Program
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        HashSet<string> userNames = new HashSet<string>(); 
        for(int i = 0; i < n; i++)
        {
            string userName = Regex.Replace(Console.ReadLine(),"[^a-zA-Z0-9]","").ToLower();
            if(userName.Length < 5) continue;
            if(!Regex.IsMatch(userName,@"\d")) continue;
            userNames.Add(userName);
        }

        if(userNames.Count==0)
        {
            Console.WriteLine("No valid user names");
            return;
        }
        var sortedName = userNames.OrderBy(u => u).ToList();
        foreach(var name in sortedName)
        {
            Console.WriteLine(name);
        }
    }
}