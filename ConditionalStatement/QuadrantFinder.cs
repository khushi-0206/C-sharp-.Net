using System;

namespace ConditionalStatement;

public class QuadrantFinder
{
    public static void FindQuadrant()
    {
        Console.Write("Enter x cordinates: ");
        int x = Int32.Parse(Console.ReadLine());
        Console.Write("Enter y cordinates");
        int y = Int32.Parse(Console.ReadLine());

        if(x==0 && y == 0)
        {
            Console.WriteLine("Center Point\n coordinates: ({0},{1})",x,y);
        }
        else if(x>0 && y > 0)
        {
            Console.WriteLine("Lies in 1st quadrant\n coordinates: ({0},{1})",x,y);
        }
        else if(x<0 && y > 0)
        {
            Console.WriteLine("Lies in 2nd quadrant\n coordinates: ({0},{1})",x,y);
        }
        else if(x<0 && y < 0)
        {
            Console.WriteLine("Lies in 3rd quadrant\n coordinates: ({0},{1})",x,y);
        
        }
        else
        {
            Console.WriteLine("Lies in 4th quadrant\n coordinates: ({0},{1})",x,y);
        }

    }
}
