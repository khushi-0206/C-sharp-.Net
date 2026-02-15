using System.ComponentModel.DataAnnotations;

class Program
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        List<Student> students = new List<Student>();
        for(int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] inputArr = input.Split(" ");
            students.Add(new Student{Name = inputArr[0], Marks = Convert.ToInt32(inputArr[1])});
        }
        int highestMarks = students.Max(s => s.Marks);
        string studentWithHighestMarks = students.Where(s => s.Marks == highestMarks).Select(s => s.Name).FirstOrDefault();
        Console.WriteLine(studentWithHighestMarks);
    }
}