using System.Text;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter string: ");
        string input = Console.ReadLine();
        string res = RemoveConsecutiveCharacter(input);
        Console.WriteLine(res);
    }
    public static string RemoveConsecutiveCharacter(string input)
    {
        StringBuilder sb = new StringBuilder();
        char c = input[0];
        for(int i = 1;i<input.Length;i++)
        {
            if(c == input[i])
            {
                continue;
            }
            else
            {
                sb.Append(c);
                c = input[i];
            }
        }
        sb.Append(input[input.Length-1]);
        return sb.ToString();
    }
}