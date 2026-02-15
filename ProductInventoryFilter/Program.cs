class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        List<Product> products = new List<Product>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            products.Add(new Product
            {
                Name = input[0],
                Category = input[1],
                Price = Convert.ToInt32(input[2])
            });
        }

        string categoryToSearch = Console.ReadLine().Trim();

        List<Product> result = products
            .Where(p => p.Category.Equals(categoryToSearch, StringComparison.OrdinalIgnoreCase))
            .Where(p => p.Price >= 100)
            .OrderBy(p => p.Price)
            .ToList();

        if (result.Count == 0)
        {
            Console.WriteLine("No Products Found");
        }
        else
        {
            foreach (var product in result)
            {
                Console.WriteLine(product.Name);
            }
        }
    }
}
