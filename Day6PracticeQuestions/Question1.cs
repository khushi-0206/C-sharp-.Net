//Q1.Write a method that returns the area of a circle for a given radius.

public class AreaOfCircle
{
    
    public static void CalculateArea()
    {
        Console.Write("Enter radius: ");
        double radius = double.Parse(Console.ReadLine());
        double area = 3.14 * radius * radius;
        Console.WriteLine("Area of Circle: {0:F2}",area);
    }
}