using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Text;

class Program
{
    public static string StringAfterManipulation(string str1, string str2)
    {
        HashSet<char> set = new HashSet<char>();
        foreach(char c in str2)
        {
            set.Add(c);
        }

        StringBuilder filtered = new StringBuilder();
        foreach(char c in str1)
        {
            if(IsConsonant(c) && set.Contains(c))
            {
                continue;
            }
            else
            {
                filtered.Append(c);
            }
        }
        StringBuilder result = new StringBuilder();
        for(int i = 0; i < filtered.Length; i++)
        {
            if(i==0 || filtered[i] != filtered[i - 1])
            {
                result.Append(filtered[i]);
            }
        }
        return result.ToString();
    }
    private static bool IsConsonant(char c)
    {
        if (!char.IsLetter(c))
        {
            return false;
        }

        return !"aeiou".Contains(c);
    }
    public static void Main()
    {
        Console.Write("Enter first String: ");
        string str1 = Console.ReadLine().ToLower();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine().ToLower();

        string result = StringAfterManipulation(str1,str2);
        Console.WriteLine("String after removal: "+result);

        
    }
}