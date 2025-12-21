using System;

namespace ConditionalStatement;

public class LeapYearChecker
{
    public static void LeapYearMain()
    {
        Console.WriteLine("Enter year: ");
        int year = Int32.Parse(Console.ReadLine());
        if((year%4==0 && year%100!=0)|| year % 400 == 0)
        {
            Console.WriteLine("{0} is Leap year",year);
        }
        else
        {
            Console.WriteLine("{0} is not a Leap Year",year);
        }
    }
}
