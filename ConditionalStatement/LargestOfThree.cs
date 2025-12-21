using System;

namespace ConditionalStatement;

public class LargestOfThree
{
    public static void LargestOfThreeMain()
    {
        Console.Write("Enter First number: ");
        int num1 = Int32.Parse(Console.ReadLine());
        Console.Write("Enter Second number: ");
        int num2 = Int32.Parse(Console.ReadLine());
        Console.Write("Enter Third number: ");
        int num3 = Int32.Parse(Console.ReadLine());
        if (num1 > num2)
        {
            if (num1 > num3)
            {
                Console.WriteLine("{0} is grateer than {1}, {2}",num1,num2,num3);
            }
            else
            {
                Console.WriteLine("{0} is grateer than {1}, {2}",num3,num1,num2);
            }
        }
        else
        {
            if (num2 > num3)
            {
                Console.WriteLine("{0} is grateer than {1}, {2}",num2,num1,num3);
            }
            else
            {
                Console.WriteLine("{0} is grateer than {1}, {2}",num3,num1,num2);
            }
        }
    }
}
