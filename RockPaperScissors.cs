using System;

namespace ConditionalStatement;

public class RockPaperScissors
{
    public static void RockPaperScissorsMain(){
        Console.WriteLine("Let's play \nEnter number from the given options: \nFor Rock: Press 1 \nFor Paper: Press 2 \nFor Scissors: Press 3");
        Console.Write("Enter choice for first Person: ");
        int choiceOfPerson1 = Int32.Parse(Console.ReadLine());
        Console.Write("Enter choice for 2nd Person: ");
        int choiceOfPerson2 = Int32.Parse(Console.ReadLine());
        if (choiceOfPerson1 == choiceOfPerson2)
        {
            Console.WriteLine("It's a draw");
        }
        else if (choiceOfPerson1 == 1)
        {
            if (choiceOfPerson2 == 2)
            {
                Console.WriteLine("Player2 wins");
            }
            else
            {
                Console.WriteLine("Player1 wins");
            }
        }
        else if (choiceOfPerson1 == 2)
        {
            if (choiceOfPerson2 == 1)
            {
                Console.WriteLine("Player1 wins");
            }
            else
            {
                Console.WriteLine("Player2 wins");
            }
        }
        else if(choiceOfPerson1 == 3)
        {
            if (choiceOfPerson2 == 1)
            {
                Console.WriteLine("Player2 wins");
            }
            else
            {
                Console.WriteLine("Player1 wins");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }
    }
}
