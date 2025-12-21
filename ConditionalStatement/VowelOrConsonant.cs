using System;

namespace ConditionalStatement;

public class VowelOrConsonant
{
    public static void VowelOrConsonantMain()
    {
        Console.Write("Enter a character: ");
        char c = char.Parse(Console.ReadLine());
        switch (c)
        {
            case 'a':
            {
                Console.WriteLine("{0} is vowel",c);
                break;
            }
            case 'e':
            {
                Console.WriteLine("{0} is vowel",c);
                break;
            }
            case 'i':
            {
                Console.WriteLine("{0} is vowel",c);
                break;
            }
            case 'o':
            {
                Console.WriteLine("{0} is vowel",c);
                break;
            }
            case 'u':
            {
                Console.WriteLine("{0} is vowel",c);
                break;
            }
            case 'A':
            {
                Console.WriteLine("{0} is vowel",c);
                break;
            }
            case 'E':
            {
                Console.WriteLine("{0} is vowel",c);
                break;
            }
            case 'I':
            {
                Console.WriteLine("{0} is vowel",c);
                break;
            }
            case 'O':
            {
                Console.WriteLine("{0} is vowel",c);
                break;
            }
            case 'U':
            {
                Console.WriteLine("{0} is vowel",c);
                break;
            }
            default:
                {
                    Console.WriteLine("{0} is consonant",c);
                    break;
                }
        }
    }
}
