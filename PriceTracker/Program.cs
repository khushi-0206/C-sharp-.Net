using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        SortedDictionary<string,decimal> products = new SortedDictionary<string, decimal>();

        for(int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split("-");
            if(input.Length<2) continue;

            string name = input[0];
            decimal price;
            if(!decimal.TryParse(input[1],out price)) continue;
            if (products.ContainsKey(name))
            {
                if (products[name] < price)
                {
                    products[name] = price;
                }
            }
            else
            {
                products.Add(name,price);
            }
        }
        
        var toRemoved = products.Where(p => p.Key.StartsWith("Temp") || p.Key.EndsWith("Old")).Select(p=> p.Key).ToList();

        foreach(var product in toRemoved)
        {
            products.Remove(product);
        }

        if(products.Count==0) Console.WriteLine("Empty Inventory");

        else
        {
            foreach(var product in products)
            {
                Console.WriteLine($"{product.Key} - {product.Value}");
            }
        }
    }
}
