//Q12

public class Summary
{
    public static void SummaryMain()
    {
        Console.Write("Enter number of elements: ");
        int n = Int32.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for(int i = 0; i < n; i++)
        {
            Console.Write("Enter element {0}: ",i+1);
            arr[i] = Int32.Parse(Console.ReadLine());
        }

        int min = arr[0];
        int max = arr[0];
        long sum = 0;
        foreach(int i in arr)
        {
            if(min>i) min = i;
            if(max<i) max = i;
            sum = sum + i;
        }
        double avg = (double)sum/n;
        Console.WriteLine("-----Summary------");
        Console.WriteLine("Min: {0}; Max: {1}; Sum: {2}; Average: {3:F2}",min,max,sum,avg);
    }
}