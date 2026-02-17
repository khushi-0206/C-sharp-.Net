public class Program
{
    public static void Main()
    {
        string[] str = Console.ReadLine()
        .Replace(".","")
        .Replace("?","")
        .Replace("!","")
        .Replace(",","")
        .ToLower().Split(" ");
        
        Dictionary<string,int> freq = new Dictionary<string, int>();
        foreach(string word in str)
        {
            if (freq.ContainsKey(word))
            {
                freq[word] = freq[word] + 1;
            }
            else
            {
                freq.Add(word,1);
            }
        }
        var removed = freq.Where(i => i.Value != 1).Select(i => i).ToDictionary();
        var sorted = removed.OrderByDescending(i => i.Value).ThenBy(i => i.Key).ToDictionary();

        if(sorted.Count == 0)
        {
            Console.WriteLine("No repeated words");
            return;
        }
        foreach(var item in sorted)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}