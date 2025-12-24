//Q4. Write a method that returns the largest of three integers using conditional logic.

public class LargestOfThree
{
    public static void FindLargestOfThree()
    {
        Console.WriteLine("Enter three numbers: ");
		int n1 = int.Parse(Console.ReadLine());
		int n2 = int.Parse(Console.ReadLine());
		int n3 = int.Parse(Console.ReadLine());
		if(n1>n2) {
			if(n1>n3){
				Console.WriteLine("{0} is largest number",n1);
			}
			else{
				Console.WriteLine("{0} is largest number",n3);
			}
		}
		else{
			if(n2>n3){
				Console.WriteLine("{0} is largest number",n2);
			}
			else{
				Console.WriteLine("{0} is largest number",n3);
			}
		}

    }
}