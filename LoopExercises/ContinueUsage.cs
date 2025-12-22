using System;

namespace LoopStatements;

public class ContinueUsage
{
    public static void PrintExceptMultipleOf3()
    {
        for(int i = 1; i <= 50; i++)
        {
            if (i % 3 == 0)
            {
                continue;
            }
            Console.Write(i+" ");
        }
    }
}
