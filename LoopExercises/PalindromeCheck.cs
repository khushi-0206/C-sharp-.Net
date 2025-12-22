using System;

namespace LoopExercises;

public class PalindromeCheck
{
    public static void CheckPalindrome()
    {
        Console.Write("Enter a number: ");
        int num = Int32.Parse(Console.ReadLine());
        int reversed = 0;
        int temp = num;
        while (temp > 0)
        {
            int digit = temp%10;
            reversed = reversed*10+digit;
            temp = temp/10;
        }
        Console.WriteLine("Reversed Number: {0}",reversed);
        if (reversed == num)
        {
            Console.WriteLine("{0} is Palindrome",num);
        }
        else
        {
            Console.WriteLine("{0} is not Palindrome",num);
        }
    }
}
