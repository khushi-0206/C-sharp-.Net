class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter size of first array:");
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];
        if (n > 0)
        {
            Console.WriteLine("Enter elements of first array (sorted):");
            
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Enter size of first array:");
        int m = int.Parse(Console.ReadLine());

        int[] b = new int[n];
        if (m > 0)
        {
            Console.WriteLine("Enter elements of first array (sorted):");
            
            for (int i = 0; i < n; i++)
            {
                b[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        int[] merged = MergeSortedArrays(a,b);

        Console.WriteLine("Merged Array: ");
        Console.WriteLine(string.Join(" ",merged));
    }
    public static T[] MergeSortedArrays<T>(T[] a, T[] b) where T : IComparable<T>
    {
        int n = a.Length;
        int m = b.Length;

        T[] merged = new T[n+m];
        int i=0,j=0,k=0;
        while(i<n && j < m)
        {
            if (a[i].CompareTo(b[j]) <= 0)
            {
                merged[k++] = a[i++];
            }
            else
            {
                merged[k++] = b[j++];
            }
        }

        while(i < n)
        {
            merged[k++] = a[i++];
        }
        while(j < m)
        {
            merged[k++] = b[j++];
        }
        return merged;
    }
}