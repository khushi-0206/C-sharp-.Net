//Q3
public class HeightCategory
{
    public static void HeightCategoryMain()
    {
        Console.Write("Enter height (in cm): ");
        int height = Int32.Parse(Console.ReadLine());
        string category;
        if (height < 150)
        {
            category = "Short";
        }
        else if(height>=150 && height <= 180)
        {
            category = "Average";
        }
        else
        {
            category = "Tall";
        }
        Console.WriteLine("Height Category: {0}",category);
    }
}