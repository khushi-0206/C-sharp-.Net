//Q14

abstract public class Employee
{
    public abstract decimal CalculatePay();
}

class HourlyEmployee : Employee
{
    private decimal rate;
    private decimal hours;
    public HourlyEmployee(decimal rate, decimal hours)
    {
        this.rate = rate;
        this.hours = hours;
    }
    public override decimal CalculatePay()
    {
        return rate * hours;
    }
}
class SalariedEmployee : Employee
{
    private decimal salary;
    public SalariedEmployee(decimal salary)
    {
        this.salary = salary;
    }
    public override decimal CalculatePay()
    {
        return salary;
    }
}
class CommissionEmployee : Employee
{
    private decimal comission;
    private decimal baseSalary;
    public CommissionEmployee(decimal comission, decimal baseSalary)
    {
        this.comission = comission;
        this.baseSalary = baseSalary;
    }
    public override decimal CalculatePay()
    {
        return baseSalary + comission;
    }
}
class EmployeeMain
{
    public static void InputMain()
    {
        System.Console.Write("Enter number of Employees: ");
        int n = Int32.Parse(Console.ReadLine());

        string[] employees = new string[n];
        for(int i = 0; i < n; i++)
        {
            employees[i] = Console.ReadLine();
        }

        decimal totalPay = 0;

        foreach (string emp in employees)
        {
            string[] parts = emp.Split(' ');
            Employee employee = null;

            if (parts[0] == "H")
            {
                employee = new HourlyEmployee(
                    decimal.Parse(parts[1]),
                    decimal.Parse(parts[2])
                );
            }
            else if (parts[0] == "S")
            {
                employee = new SalariedEmployee(
                    decimal.Parse(parts[1])
                );
            }
            else if (parts[0] == "C")
            {
                employee = new CommissionEmployee(
                    decimal.Parse(parts[1]),
                    decimal.Parse(parts[2])
                );
            }

            totalPay += employee.CalculatePay();
        }

        totalPay = Math.Round(totalPay, 2, MidpointRounding.AwayFromZero);
        Console.WriteLine("Total Payroll: {0}",totalPay);
    }
}