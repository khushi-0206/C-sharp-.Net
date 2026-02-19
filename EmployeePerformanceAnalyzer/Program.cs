public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<int,Employee> employees = new Dictionary<int,Employee>();
        for(int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(',');
            if(input.Length<4) continue;

            
            if(!int.TryParse(input[0],out int id))
            {
                continue;
            }
            if(!decimal.TryParse(input[3],out decimal salary)) continue;

            try
            {
                if(salary <= 0)
                {
                    throw new Exception("Invalid Salary");
                }
                if(input[1].Length < 3) continue;
                Employee emp = new PermanentEmployee
                {
                    ID = id,
                    Name = input[1],
                    Department = input[2],
                    Salary = salary 
                };
                if (employees.ContainsKey(id))
                {
                    if(salary > employees[id].Salary)
                    {
                        employees[id] = emp;
                    }
                }
                else
                {
                    employees.Add(id,emp);
                }

            }
            catch(Exception e)
            {
                continue;
            }

        }
        if(employees.Count==0) 
        {
            Console.WriteLine("No employees");
            return;
        }
        var sortedEmployees = employees.Values.OrderByDescending(e => e.Salary);

        foreach(var emp in sortedEmployees)
        {
            Console.WriteLine($"{emp.Name} {emp.Department} {emp.Salary} {emp.GetBonus()}");
        }

    
    }
}