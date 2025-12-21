using System;

namespace ConditionalStatement;

public class TriangleType
{
public static void CheckTriangleType()
    {
        Console.WriteLine("Enter the sides of triangle: ");
        Console.Write("Enter side1: ");
        int side1 = Int32.Parse(Console.ReadLine());
        Console.Write("Enter side2: ");
        int side2 = Int32.Parse(Console.ReadLine());
        Console.Write("Enter side3: ");
        int side3 = Int32.Parse(Console.ReadLine());
        if((side1 + side2 > side3) || (side1 + side3 > side2)|| (side2 + side3 > side1))
        {
            if(side1==side2 && side2 == side3)
            {
                Console.WriteLine("Triangle is equilateral");
            }
            else if((side1==side2 || side1==side3 || side2 == side3))
            {
                Console.WriteLine("Triangle is isosceles");
            }
            else
            {
                Console.WriteLine("Traianle is Scalenee");
            }
        }
    }
}
