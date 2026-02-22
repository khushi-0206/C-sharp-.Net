class Program
{
    public static void Main()
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee { Id = 1, Name = "Arun", Department = "IT", Salary = 60000 },
            new Employee { Id = 2, Name = "Meera", Department = "HR", Salary = 45000 },
            new Employee { Id = 3, Name = "John", Department = "IT", Salary = 75000 },
            new Employee { Id = 4, Name = "Riya", Department = "Finance", Salary = 82000 },
            new Employee { Id = 5, Name = "Karan", Department = "HR", Salary = 58000 },
            new Employee { Id = 6, Name = "Neha", Department = "IT", Salary = 50000 },
            new Employee { Id = 7, Name = "Aman", Department = "Finance", Salary = 67000 },
            new Employee { Id = 8, Name = "Pooja", Department = "Sales", Salary = 72000 }
        };

        var result = employees.Where(e => e.Salary > 50000).GroupBy(e => e.Department)
            .ToDictionary(g => g.Key,g => g.ToList());
        foreach (var dept in result)
        {
            Console.Write(dept.Key + " -> ");
            Console.WriteLine(string.Join(", ", dept.Value.Select(e => e.Name)));
        }
    }
}