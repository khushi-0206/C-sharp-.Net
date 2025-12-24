//Q5. Convert a number of seconds into a string formatted as m:ss.
public class SecondsToMinutes
{
    public static void ConvertSecondsToMinutes()
    {
        Console.Write("Enter minutes: ");
        int totalSeconds = Int32.Parse(Console.ReadLine());
        int minutes = totalSeconds/60;
        int seconds = totalSeconds%60;
        string formatted = minutes + ":" + seconds.ToString("D2");
        Console.WriteLine("Formatted {m:ss}: "+formatted);
    }
}
