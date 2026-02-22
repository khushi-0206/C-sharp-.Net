using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Input list
        List<string> products = new List<string>()
        {
            "Pen", "Book", "Pen", "Pencil", "Book"
        };

        // LINQ to find duplicates
        List<string> duplicates = products.GroupBy(p => p).Where(g => g.Count() > 1)
                                  .Select(g => g.Key).ToList();
        Console.WriteLine("Duplicate Products:");
        foreach (var item in duplicates)
        {
            Console.WriteLine(item);
        }
    }
}