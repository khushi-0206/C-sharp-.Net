using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

public class Program
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        List<string> codes = new List<string>();
        for(int i = 0; i < n; i++)
        {
            codes.Add(Console.ReadLine());
        }

        List<int> res = ValidateCodes(codes);
        foreach(int r in res)
        {
            Console.WriteLine(r);
        }
    }
    public static List<int> ValidateCodes(List<string> codes)
    {
        List<int> res = new List<int>();
        foreach(string code in codes)
        {
            if (Regex.IsMatch(code, @"^[A-Z]{2}\d{3}[a-z]$"))
            {
                res.Add(1);
            }
            else
            {
                res.Add(0);
            }
        }
        return res;
    }
}