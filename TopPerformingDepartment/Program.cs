class Employee
{
    public string EmployeeName{get;set;}
    public string Department{get;set;}
    public int Salary{get;set;}
}

class Program
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        List<Employee> employees = new List<Employee>();

        for(int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            int salary;
            if(!int.TryParse(input[2],out salary))
            {
                continue;
            }
            if(salary > 0)
            {
                employees.Add(new Employee{EmployeeName = input[0],Department = input[1],Salary = salary});
            }
        }

        var res = employees.GroupBy(e => e.Department)
                            .Select(g => new
                            {
                                Department = g.Key,
                                AvgSalary = g.Average(e => e.Salary)
                            })
                            .OrderByDescending(e => e.AvgSalary)
                            .ThenBy(d => d.Department)
                            .FirstOrDefault();
        if(res == null)
        {
            Console.WriteLine("No data");
        }
        else
        {
            Console.WriteLine(res.Department);
        }
                            
    }
}