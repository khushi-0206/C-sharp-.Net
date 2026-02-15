using System.Text.RegularExpressions;

class Employee
{
    public string EmployeeCode{get;set;}
    public string Name{get;set;}
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
            string[] inputs = Console.ReadLine().Split(' ');
            employees.Add(new Employee{EmployeeCode = inputs[0], Name = inputs[1], Salary = Convert.ToInt32(inputs[2])});
        }

        List<Employee> res = employees.Where(e => Regex.IsMatch(e.EmployeeCode,@"^[A-Z]{2}\d{3}[a-z]$"))
                            .Where(e => e.Salary >= 30000)
                            .OrderByDescending(e => e.Salary).ThenBy(e => e.Name)
                            .ToList();
        if (res.Count == 0)
        {
            Console.WriteLine("No Valid Employees");
        }
        else
        {
            foreach(Employee emp in res)
            {
                Console.WriteLine(emp.Name);
            }
        }
    }
}