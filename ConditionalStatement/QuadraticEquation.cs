using System;

namespace ConditionalStatement;

public class QuadraticEquation
{
    public static void FindRoots()
    {
        Console.Write("Enter value of a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter value of b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter value of c: ");
        double c = double.Parse(Console.ReadLine());
        double D = b*b - 4*a*c;
        if (D > 0)
        {
            double root1 = (-b + Math.Sqrt(D))/(2*a);
            double root2 = (-b - Math.Sqrt(D))/(2*a);
            Console.WriteLine("Roots are real and distinct:");
            Console.WriteLine("Root1: {0}",root1);
            Console.WriteLine("Root2: {0}",root2);
        }
        else if (D == 0)
        {
            double root = (-b)/(2*a);
            Console.WriteLine("Roots are real and equal:");
            Console.WriteLine("Root1: {0}",root);
            
        }
        else
        {
            Console.WriteLine("Roots are imaginary (no real roots)");
        }

    }
}
