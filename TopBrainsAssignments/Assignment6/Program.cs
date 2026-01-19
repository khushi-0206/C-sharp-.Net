using System;

class Program
{
    public static void Main()
    {
        Console.Write("Enter height (in cm): ");
        int height = Convert.ToInt32(Console.ReadLine());

        string category = HeightCategory(height);
        Console.WriteLine(category);
    }
    public static string HeightCategory(int height)
    {
        if (height < 150)
        {
            return "Short";
        }
        else if(height >=150 && height < 180)
        {
            return "Average";
        }
        else
        {
            return "Tall";
        }
    }
}