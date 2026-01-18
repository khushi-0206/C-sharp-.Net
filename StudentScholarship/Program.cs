public delegate bool IsEligibleForScholarship(Student std);
class Program
{
    public static void Main()
    {
        List<Student> students = new List<Student>()
        {
            new Student("Ravi",85,'A'),
            new Student("Neha", 75,'A'),
            new Student("Amit", 90,'B'),
            new Student("Sneha", 88,'A')
        };
        IsEligibleForScholarship eligibilityDelegate = ScholarshipEligibility;
        string result = Student.GetEligibleStudents(students, eligibilityDelegate);
        Console.WriteLine(result);
    }
    public static bool ScholarshipEligibility(Student std)
    {
        return std.Marks > 80 && std.SportsGrade == 'A';
    }
}