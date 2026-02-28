class Program
{
    static void Main()
    {
        StudentDAL dal = new StudentDAL();
        int choice;

        do
        {
            Console.WriteLine("\n1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Update Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Student s = new Student();
                    Console.Write("Name: ");
                    s.Name = Console.ReadLine();
                    Console.Write("Age: ");
                    s.Age = int.Parse(Console.ReadLine());
                    Console.Write("Course: ");
                    s.Course = Console.ReadLine();
                    dal.AddStudent(s);
                    break;

                case 2:
                    dal.GetAllStudents();
                    break;

                case 3:
                    Student us = new Student();
                    Console.Write("ID: ");
                    us.Id = int.Parse(Console.ReadLine());
                    Console.Write("New Name: ");
                    us.Name = Console.ReadLine();
                    Console.Write("New Age: ");
                    us.Age = int.Parse(Console.ReadLine());
                    Console.Write("New Course: ");
                    us.Course = Console.ReadLine();
                    dal.UpdateStudent(us);
                    break;

                case 4:
                    Console.Write("ID: ");
                    int id = int.Parse(Console.ReadLine());
                    dal.DeleteStudent(id);
                    break;
            }

        } while (choice != 5);
    }
}