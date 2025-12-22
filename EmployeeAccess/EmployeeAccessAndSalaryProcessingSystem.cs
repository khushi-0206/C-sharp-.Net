using System;
namespace EmployeeAccess;
public class EmployeeAccessAndSalaryProcessingSystem
{
    public static void EmployeeAccessAndSalaryProcessingSystemMain()
    {
        //Input Employee Id
        Console.Write("Enter your Employee ID: ");
        int empId = Int32.Parse(Console.ReadLine());

        //Input Employee Name
        Console.Write("Enter your Name: ");
        string empName = Console.ReadLine();

        //Input Age
        Console.WriteLine("Enter your age: ");
        int age = Int32.Parse(Console.ReadLine());

        //validating age 
        if (age < 21)
        {
            Console.WriteLine("Employee is not eligible to work");
            return;
        }

        //Menu display
        Console.WriteLine("--------------Choose Department-----------");
        Console.WriteLine("1. IT\n2.HR\n3.Finance");

        //Intput department 
        Console.Write("Enter department: ");
        int deptChoice = Int32.Parse(Console.ReadLine());

        // Delarling fields to set later on based on cdepartment
        int roleChoice;
        string deptName = "";
        string role = "";
        double baseSalary = 0;
        double finalSalary = 0;

        //nested switch 
        switch (deptChoice)
        {
            //for IT department
            case 1:
            {
                Console.WriteLine("------choose role---------");
                Console.WriteLine("1. Developer\t2. Testing");

                //Input Role
                roleChoice = Int32.Parse(Console.ReadLine());
                deptName = "IT";
                    switch (roleChoice)
                    {
                        case 1:
                        {
                            Console.Write("Enter your Base salary: ");
                            baseSalary = Int32.Parse(Console.ReadLine());
                            role = "Developer";
                            finalSalary = SalaryCalculation(baseSalary,30);
                            break; 
                        }
                        case 2:
                        {
                            Console.Write("Enter your Base salary: ");
                            baseSalary = Int32.Parse(Console.ReadLine());
                            role = "Tester";
                            finalSalary = SalaryCalculation(baseSalary,25);
                            break;   
                        }
                        default:
                        {
                            Console.WriteLine("Invalid Choice"); 
                            return;       
                        }

                    }
                break;
            }

            //for HR department
            case 2:
            {
                Console.WriteLine("------choose role---------");
                Console.WriteLine("1. Recruiter\t2. Payroll"); 

                //input role  
                roleChoice = Int32.Parse(Console.ReadLine());
                deptName = "HR";
                switch (roleChoice)
                    {
                        case 1:
                        {
                            Console.Write("Enter your Base salary: ");
                            baseSalary = Int32.Parse(Console.ReadLine());
                            role = "Recruiter";
                            finalSalary = SalaryCalculation(baseSalary,20);
                            break; 
                        }
                        case 2:
                        {
                            Console.Write("Enter your Base salary: ");
                            baseSalary = Int32.Parse(Console.ReadLine());
                            role = "Payroll";
                            finalSalary = SalaryCalculation(baseSalary,22);
                            break;   
                        }
                        default:
                        {
                            Console.WriteLine("Invalid Choice");
                            return;        
                        }
                    }
                break;
            }

            //For finance department
            case 3:
            {
                Console.WriteLine("------choose role---------");
                Console.WriteLine("1. Accountant\t2. Auditor");

                //Input role
                roleChoice = Int32.Parse(Console.ReadLine()); 
                deptName = "Finance";
                switch (roleChoice)
                    {
                        case 1:
                        {
                            Console.Write("Enter your Base salary: ");
                            baseSalary = Int32.Parse(Console.ReadLine());
                            role = "Accountant";
                            finalSalary = SalaryCalculation(baseSalary,28);
                            break; 
                        }
                        case 2:
                        {
                            Console.Write("Enter your Base salary: ");
                            baseSalary = Int32.Parse(Console.ReadLine());
                            role = "Auditor";
                            finalSalary = SalaryCalculation(baseSalary,26);
                            break;   
                        }
                        default:
                        {
                            Console.WriteLine("Invalid Choice"); 
                            return;       
                        }
                    }
                break;
            }
            default:
            {
                Console.WriteLine("Invalid Choice"); 
                return;       
            }
        }

        // for access level
        string accessLevel;
        if(finalSalary>=60000 && deptName == "IT")
        {
            accessLevel = "Admin access";
        }
        else if(finalSalary>=60000 && (deptName == "HR" || deptName == "Finance")){
            accessLevel = "Manager access";
        }
        else
        {
            accessLevel = "Employee access";
        }

        //printing the details
        Console.WriteLine("----------------Employee Details-----------------------");
        Console.WriteLine("Employee Id: {0}",empId);
        Console.WriteLine("Employee Name: {0}",empName);
        Console.WriteLine("Employee Age: {0}",age);
        Console.WriteLine("Employee's Department: {0}",deptName);
        Console.WriteLine("Employee's role: {0}",role);
        Console.WriteLine("Employee's Basic Salary: {0}",baseSalary);
        Console.WriteLine("Employee's Final Salary: {0}",finalSalary);
        Console.WriteLine("Employee's access level: {0}",accessLevel);
    }

    //method to calculate final salary 
    public static double SalaryCalculation(double baseSalary, int allowance)
    {
        return baseSalary + (baseSalary *allowance/100.0);

    }
}
