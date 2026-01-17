using System.Collections.Generic;
using System;

class Program
{
    public static List<int> NumberList = new List<int>();
    public static void Main()
    {
       
       Program p = new Program();
        System.Console.WriteLine("Enter numver of subjects: ");
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            System.Console.WriteLine($"Enter score {i+1}: ");
            int value = int.Parse(Console.ReadLine());
            p.AddNumber(value);
        }
        double gpa = p.GetGPAScored();
        if(gpa == -1)
        {
            System.Console.WriteLine("No Numbers");
            return;
        }
        System.Console.WriteLine($"GPA: {gpa:F2}");
        char? grade = p.GetGradeScored(gpa);
        if(grade == null)
        {
            Console.WriteLine("Invalid GPA");
        }
        else
        {
            Console.WriteLine($"Grade: {grade}");
        }
        
    }
    public void AddNumber(int marks)
    {
        int gpa;

        if (marks >= 90) gpa = 10;
        else if (marks >= 80) gpa = 9;
        else if (marks >= 70) gpa = 8;
        else if (marks >= 60) gpa = 7;
        else if (marks >= 50) gpa = 6;
        else gpa = 5;

        NumberList.Add(gpa);
    }
    public double GetGPAScored()
    {
        if(NumberList.Count == 0)
        {
            return -1;
        }
        int sum = 0;
        foreach(int num in NumberList)
        {
            sum += num*3;
        }
        double gpa = (double) sum / (NumberList.Count*3);
        return gpa;
    }
    public char? GetGradeScored(double gpa)
    {
        if(gpa < 5 || gpa > 10) return null;
        if(gpa==10) return 'S';
        else if (gpa >= 9) return 'A';
        else if (gpa >= 8) return 'B';
        else if (gpa >= 7) return 'C';
        else if (gpa >= 6) return 'D';
        else return 'E';
    }
}