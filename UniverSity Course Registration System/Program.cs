using System;
using System.Collections.Generic;
using System.Linq;

namespace University_Course_Registration_System
{
     // =========================
    // Program (Menu-Driven)
    // =========================
    class Program
    {
        static void Main()
        {
            UniversitySystem system = new UniversitySystem();
            bool exit = false;

            Console.WriteLine("Welcome to University Course Registration System");

            while (!exit)
            {
                Console.WriteLine("\n1. Add Course");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Register Student for Course");
                Console.WriteLine("4. Drop Student from Course");
                Console.WriteLine("5. Display All Courses");
                Console.WriteLine("6. Display Student Schedule");
                Console.WriteLine("7. Display System Summary");
                Console.WriteLine("8. Exit");

                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                try
                {
                    // TODO:
                    // Implement menu handling logic using switch-case
                    // Prompt user inputs
                    // Call appropriate UniversitySystem methods
                    switch (choice)
                    {
                        case "1":
                        {  
                            Console.Write("Enter Course Code: ");
                            string code = Console.ReadLine();

                            Console.Write("Enter Course Name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter Credits (1-4): ");
                            if (!int.TryParse(Console.ReadLine(), out int credits))
                            {
                                Console.WriteLine("Invalid credits input");
                                break;
                            }

                            Console.Write("Enter Max Capacity (default 50): ");
                            string capInput = Console.ReadLine();
                            int capacity = string.IsNullOrWhiteSpace(capInput) ? 50 : int.Parse(capInput);

                            Console.Write("Enter Prerequisites (comma-separated, or Enter for none): ");
                            string prereqInput = Console.ReadLine();

                            List<string> prerequisites = string.IsNullOrWhiteSpace(prereqInput)
                                ? new List<string>()
                                : prereqInput.Split(',').Select(p => p.Trim()).ToList();

                            system.AddCourse(code, name, credits, capacity, prerequisites);
                            Console.WriteLine($"Course {code} added successfully.");                            
                            
                            break;    
                        }
                        case "2":
                        { 
                            Console.Write("Enter Student ID: ");
                            string id = Console.ReadLine();

                            Console.Write("Enter Name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter Major: ");
                            string major = Console.ReadLine();

                            Console.Write("Enter Max Credits (default 18): ");
                            string maxInput = Console.ReadLine();
                            int maxCredits = string.IsNullOrWhiteSpace(maxInput) ? 18 : int.Parse(maxInput);

                            Console.Write("Enter Completed Courses (comma-separated, or Enter for none): ");
                            string completedInput = Console.ReadLine();
                            List<string> completedCourses = string.IsNullOrWhiteSpace(completedInput)
                                ? new List<string>()
                                : completedInput.Split(',').Select(c => c.Trim()).ToList();

                            system.AddStudent(id, name, major, maxCredits, completedCourses);
                            Console.WriteLine($"Student {id} added successfully.");
                            break;    
                        }
                        case "3":
                        { 
                            Console.Write("Enter Student ID: ");
                            string studentId = Console.ReadLine();

                            Console.Write("Enter Course Code: ");
                            string courseCode = Console.ReadLine();

                            if (!system.RegisterStudentForCourse(studentId, courseCode))
                                Console.WriteLine("Registration failed.");  
                            break;    
                        }
                        case "4":
                        { 
                            Console.Write("Enter Student ID: ");
                            string studentId = Console.ReadLine();

                            Console.Write("Enter Course Code: ");
                            string courseCode = Console.ReadLine();

                            if (system.DropStudentFromCourse(studentId, courseCode))
                                Console.WriteLine("Course dropped successfully.");
                            else
                                Console.WriteLine("Drop failed.");  
                            break;    
                        }
                        case "5":
                        {   
                            system.DisplayAllCourses();
                            break;    
                        }
                        case "6":
                        {   
                            Console.Write("Enter Student ID: ");
                            string studentId = Console.ReadLine();
                            system.DisplayStudentSchedule(studentId);
                            break;    
                        }
                        case "7":
                        {   
                            system.DisplaySystemSummary();
                            break;    
                        }
                        case "8":
                        {   
                            exit = true;
                            Console.WriteLine("Exiting..."); 
                            break;   
                        }
                        default:
                        {   
                            Console.WriteLine("Invalid choice. Try again.");
                            break;    
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}

