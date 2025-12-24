//Q6
public class Sum
{
    public static void FindSum()
    {
        Console.Write("Enter the size: ");
        int size = Int32.Parse(Console.ReadLine());

        int[] numArr = new int[size];
        for(int i = 0; i < size; i++)
        {
            numArr[i] = Int32.Parse(Console.ReadLine());
        }

        int sum = 0;
        for(int i=0;i<size;i++)
        {
            if (numArr[i] == 0)
            {
                break;
            }
            else if (numArr[i] > 0)
            {
                sum = sum + numArr[i];
            }
            else
            {
                continue;
            }
        }
        Console.WriteLine("Sum: "+sum);
    }
}