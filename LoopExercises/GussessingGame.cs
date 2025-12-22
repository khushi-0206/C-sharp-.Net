using System;

namespace LoopStatements;

public class GussessingGame
{
    public static void GussessingGameMain()
    {
        Random rand = new Random();
        int numberToGuess = rand.Next(1,1001);
        int numEnteredByUser;
        Console.Write("Welcome to the guessing game\nyou need to guess a random number by Hit and try");
        do
        {
            Console.Write("Enter a number between 1-1000: ");
            numEnteredByUser = Int32.Parse(Console.ReadLine());
            if (numberToGuess > numEnteredByUser)
            {
                Console.WriteLine("Number is short \nTry with larger number!!");
            }
            else if(numberToGuess<numEnteredByUser)
            {
                Console.WriteLine("Number is big \nTry with smaller number..");
            }
            else
            {
                Console.WriteLine("Yeah! you guessed it..");
                break;
            }

        }while(true);
    }
}
