class Program
{
    public static double FeetToCentimeters(int feet)
    {
        double centimeters = feet * 30.48;
        return Math.Round(centimeters, 2, MidpointRounding.AwayFromZero);
    }
    public static void Main()
    {
        System.Console.WriteLine("Enter value in feet: ");
        int feet = Convert.ToInt32(Console.ReadLine());
        double result = FeetToCentimeters(feet);
        Console.WriteLine(result); 
    }
}
