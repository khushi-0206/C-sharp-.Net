public class Student
{
    public int RollNo{get;set;}
    public string Name{get;set;}
    public int Marks{get;set;}
    public char SportsGrade{get;set;}
    public Student(string name, int marks, char sportsGrade)
    {
        Name = name;
        Marks = marks;
        SportsGrade = sportsGrade;
    }

    public static string GetEligibleStudents(List<Student> studentsList, IsEligibleForScholarship isEligible)
    {
        if(studentsList == null || isEligible == null)
        {
            return string.Empty;
        }
        var eligibleStudents = studentsList.Where(s => isEligible(s)).Select(s => s.Name);
        return string.Join(",", eligibleStudents);
    }

}
