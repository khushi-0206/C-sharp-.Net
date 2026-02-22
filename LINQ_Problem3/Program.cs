using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // CSV input
        List<string> csvData = new List<string>()
        {
            "Ravi,87",
            "Kumar,98",
            "Arun,92"
        };

        // LINQ query to find top 3 scorers
        List<string> topScorers = csvData
            .Select(line => line.Split(','))          // Split CSV
            .Select(data => new
            {
                Name = data[0],
                Marks = int.Parse(data[1])
            })
            .OrderByDescending(s => s.Marks)           // Sort by marks
            .Take(3)                                   // Top 3
            .Select(s => s.Name)                        // Select names
            .ToList();

        // Output
        Console.WriteLine("Top 3 Scorers:");
        foreach (var name in topScorers)
        {
            Console.WriteLine(name);
        }
    }
}