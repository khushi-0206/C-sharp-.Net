using System.Text.RegularExpressions;
public class Program
{
    public static void Main()
    {
        int n  = Convert.ToInt32(Console.ReadLine());
        string pattern = @"^[A-Za-z]{3}[-]\d{4}";
        List<string> validCodes = new List<string>();
        for(int i = 0; i < n; i++)
        {
            string input = Console.ReadLine().Trim();
            Match match = Regex.Match(input,pattern);
            if (match.Success)
            {
                validCodes.Add(match.Groups[0].Value);
            }
        }
        if (validCodes.Count == 0)
        {
            Console.WriteLine("No Valid Codes");
            return;
        }
        Console.WriteLine("Output: ");
        validCodes.Sort();
        foreach(var code in validCodes)
        {
            Console.WriteLine(code);
        }
    }
}