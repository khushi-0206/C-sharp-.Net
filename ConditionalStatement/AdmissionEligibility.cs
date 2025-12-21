using System;

namespace ConditionalStatement;

public class AdmissionEligibility
{
    public static void AdmissionEligibilityMain()
    {
        Console.Write("Enter your marks in Math: ");
        int mathMarks = Int32.Parse(Console.ReadLine());
        Console.Write("Enter your marks in Physics: ");
        int physicsMarks = Int32.Parse(Console.ReadLine());
        Console.Write("Enter your marks in Chemistry: ");
        int chemistryMarks = Int32.Parse(Console.ReadLine());
        int totalMarks = mathMarks+physicsMarks+chemistryMarks;
        if(mathMarks>=65 && physicsMarks>=55 && chemistryMarks>=50 &&(totalMarks>=180 || (totalMarks - chemistryMarks) > 140))
        {
            Console.Write("Congratulations You are eligible!!! ");
        }
        else{
            Console.Write("Oops! you are not eligible");
        
        }

    }
}
