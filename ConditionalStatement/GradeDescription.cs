using System;

namespace ConditionalStatement;

public class GradeDescription
{
    public static void GradeDescriptionMain()
    {
        Console.WriteLine("Enter Grade: E,V,G,A,F");
        char c = char.Parse(Console.ReadLine());
        switch (c)
        {
            case 'E':
            {
                Console.WriteLine("Excellent");
                break;
            }
            case 'V':
            {
                Console.WriteLine("Very Good");
                break;
            }
            case 'G':
            {
                Console.WriteLine("Good");
                break;
            }
            case 'A':
            {
                Console.WriteLine("Average");
                break;
            }
            case 'F':
            {
                Console.WriteLine("Fail");
                break;
            }
            default:
                {
                    Console.Write("Invalid Input");
                    break;
            }
        }
    }
}
