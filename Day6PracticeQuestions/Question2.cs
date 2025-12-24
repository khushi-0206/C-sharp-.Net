// Q2. Write a method that converts feet to centimeters.
// Use: 1 foot = 30.48 cm

public class FeetToCentimeters
{
    public static void FeetToCentimetersConvertor()
    {
        System.Console.WriteLine("Enter feets: ");
        double feets = double.Parse(Console.ReadLine());
        double centimeters = feets * 30.48;
        System.Console.WriteLine("Centimeters: {0:F2}",centimeters);
    }
}