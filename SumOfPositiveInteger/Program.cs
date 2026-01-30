using System;
using System.Runtime.CompilerServices;
class Program
{
    public static void Main()
    {
        Console.Write("Enter size: ");
        int n = Int32.Parse(Console.ReadLine());

        int[] nums = new int[n];

        for(int i = 0; i < n; i++)
        {
            nums[i] = Int32.Parse(Console.ReadLine());
        }

        int result = 0;
        for(int i = 0; i < n; i++)
        {
            if(nums[i] < 0)
            {
                continue;
            }
            else if (nums[i] == 0)
            {
                break;
            }
            else
            {
                result += nums[i];
            }
        }
        Console.WriteLine("Sum: "+result);
    }
}