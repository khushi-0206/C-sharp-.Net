
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_Assignment_BoilerPlateCode.Repos;
using LINQ_Assignment_BoilerPlateCode.DTOs;
using LINQ_Assignment_BoilerPlateCode.Models;

namespace LINQ_Assignment_BoilerPlateCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // =======================
            // SAMPLE DATA
            // =======================
            var employees = EmployeeRepo.SeedEmployees();
            var projects = ProjectRepo. SeedProjects();

            Console.WriteLine("LINQ Scenario Boilerplate Loaded");
            //1.1
            Console.WriteLine("query 1.1");
            List<Employee> highEarningEmployees = GetHighEarningEmployees(employees);
            foreach(var item in highEarningEmployees)
            {
                Console.WriteLine($"{item.Name}\t{item.Salary}");
            }
            Console.WriteLine();

            //1.2
            Console.WriteLine("query 1.2");
            List<String> employeesName = GetEmployeeNames(employees);
            foreach (var item in employeesName)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //1.3
            Console.WriteLine("query 1.3");
            bool hasHr = HasHREmployees(employees);
            Console.WriteLine(hasHr);
            Console.WriteLine();

            //2.1
            Console.WriteLine("query 2.1");
            List<DepartmentCount> deparmentWiseCount = GetDepartmentWiseCount(employees);
            foreach (var item in DepartmentCount)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //2.2
            Console.WriteLine("query 2.2");
            Employee hightestPaidEmployee = GetHighestPaidEmployee(employees);
            Console.WriteLine($"{highPaidEmployee.Name}\t {highPaidEmployee.Salary}");
            Console.WriteLine();

            //2.3
            Console.WriteLine("query 2.3");
            List<Employees> sortedEmpList = SortEmployeesBySalaryAndName(employees);
            foreach (var employee in sortedEmpList)
            {
                Console.WriteLine($"{employee.Name}\t{employee.Salary}"); 
            }
            Console.WriteLine();
            Console.ReadLine();

        }

        // =====================================================
        // 🟢 SECTION 1 – HR ANALYTICS
        // =====================================================

        // TODO 1.1: Get employees earning more than 60,000
        static List<Employee> GetHighEarningEmployees(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            var highEarningEmployees = employees.Where(e => e.Salary > 60000).ToList();
            return highEarningEmployees;
        }

        // TODO 1.2: Get list of employee names only
        static List<string> GetEmployeeNames(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            var employeesName = employees.Select(e => e.Name).ToList();
            return employeesName;
        }

        // TODO 1.3: Check if any employee belongs to HR department
        static bool HasHREmployees(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            bool hasHrEmployee = employees.Any(e => e.Deparment == "HR");
            return hasHrEmployee;
        }

        // =====================================================
        // 🟡 SECTION 2 – MANAGEMENT INSIGHTS
        // =====================================================

        // TODO 2.1: Get department-wise employee count
        static List<DepartmentCount> GetDepartmentWiseCount(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            var departmentWiseCount = employees.GroupBy(e => e.Department).Select(group => new DepartmentCount
            {
                Department = group.Key,
                Count = group.Count()
            }).ToList();
            return departmentWiseCount;
        }

        // TODO 2.2: Find the highest paid employee
        static Employee GetHighestPaidEmployee(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            Employee hightPaidEmployee = employees.OrderByDescending(e => e.Salary).FirstOrDefault();
            return hightPaidEmployee;
        }

        // TODO 2.3: Sort employees by Salary (DESC), then Name (ASC)
        static List<Employee> SortEmployeesBySalaryAndName(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            var sortedEmployeeList = employees.OrderByDescending(e => e.Salary).ThenBy(e.Name).ToList();
            return sortedEmployeeList;
        }

        // =====================================================
        // 🔵 SECTION 3 – PROJECT & SKILL INTELLIGENCE
        // =====================================================

        // TODO 3.1: Join employees with projects
        static List<EmployeeProject> GetEmployeeProjectMappings(
            List<Employee> employees,
            List<Project> projects)
        {
            // TODO: Write LINQ query here
            throw new NotImplementedException();
        }

        // TODO 3.2: Find employees who are NOT assigned to any project
        static List<Employee> GetUnassignedEmployees(
            List<Employee> employees,
            List<Project> projects)
        {
            // TODO: Write LINQ query here
            var unassignedEmployees = employees.Where(e => !projects.Any(p => p.EmployeeId == e.EmployeeId)).ToList();
            return unassignedEmployees;
        }

        // TODO 3.3: Get all unique skills across the organization
        static List<string> GetAllUniqueSkills(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            var getUniqueSkills = employees.Select(e => e.Skills).Distinct().To;
            return getAllUniqueSkills;
        }

        // =====================================================
        // 🔴 SECTION 4 – ADVANCED WORKFORCE ANALYTICS
        // =====================================================

        // TODO 4.1: Get top 3 highest-paid employees per department
        static List<DepartmentTopEmployees> GetTopEarnersByDepartment(
            List<Employee> employees)
        {
            // TODO: Write LINQ query here
            var topEarners = employees.GroupBy(e => e.Department).Select(n => new DepartmentTopEmployees
            {
                Department = n.Key,
                TopEmployees = n.OrderByDescending(e => e.Salary).Take(3).ToList()
            }).ToList();
            return topEarners;
        }

        // TODO 4.2: Remove duplicate employees based on Id
        static List<Employee> RemoveDuplicateEmployees(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            var RemoveDuplicate = employees.GroupBy(e => e.Id).Select(n => n.First()).ToList();
            return RemoveDuplicate;
        }

        // TODO 4.3: Implement pagination
        static List<Employee> GetEmployeesByPage(
            List<Employee> employees,
            int pageNumber,
            int pageSize = 5)
        {
            // TODO: Write LINQ query here
            throw new NotImplementedException();
        }


    }
}
