using System;

namespace LoopStatements;

public class MenuSystem
{
    public static void MenuSystemMain()
    {
        do
        {
            Console.WriteLine("-------MENU---------\n1. Armstrong Number\n2. Palindrome Number\n3. factorial\n4. Prime number\n5.Binary to Decimal\n6.Sum of Digits\nPress 0 to stop\nEnter your choice: ");
            int choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                {
                    ArmstrongNumber.CheckArmstrong();
                    break;  
                }
                case 2:
                {
                    PalindromeCheck.CheckPalindrome();
                    break;  
                }
                case 3:
                {
                    Factorial.FindFactorial();
                    break;  
                }
                case 4:
                {
                    PrimeNumber.CheckPrime();
                    break;  
                }
                case 5:
                {
                    BinaryToDecimal.BinaryToDecimalMain();
                    break;  
                }
                case 6:
                {
                    SumOfDigits.SumOfDigitsMain();
                    break;  
                }
                case 0:
                {
                    Console.WriteLine("Exiting..");
                   return;
                }
                default:
                {
                    Console.Write("Invalid choice: ");
                    break;
                }
            }
        }while(true);
    }
}
