using System;

namespace LoopStatements;

public class SearchWithGoto
{
    public static void SearchWithGotoMain()
    {
        int[,] arr = {{1,2,3},{4,5,6},{7,8,9}};
        Console.Write("Enter key you want to find: ");
        int key = Int32.Parse(Console.ReadLine());
        bool found = false;
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                if(arr[i,j] == key)
                {
                    found = true;
                    goto Found; // exit thorough all nested loops
                }
            }
        }
        Found:
            Console.WriteLine(found? "Element found" : "Element not found");

    }
}
