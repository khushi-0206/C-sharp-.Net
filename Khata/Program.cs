// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

Khata kObj = new Khata();
do
{
    Console.WriteLine("---------------- MENU --------------------");
    Console.WriteLine("1. Add items\n2. items Count\n3. Total Amount\n4. Exit");
    Console.Write("Enter choice: ");
    int choice = Int32.Parse(Console.ReadLine());

    if (choice == 1)
    {
        Console.Write("Enter item: ");
        string item = Console.ReadLine();

        Console.Write("Enter amount: ");
        int amount = Int32.Parse(Console.ReadLine());
        kObj.AddItem(item, amount);
        Console.WriteLine("item added");
    }
    else if (choice == 2)
    {
        Console.WriteLine(kObj.getRepeatAmount());
    }
    else if(choice == 3)
    {
        int totalAmount = kObj.getTotal();
        Console.WriteLine(totalAmount);
    }
    else if (choice == 4)
    {
        Console.WriteLine("exiting...");
        return;
    }
    else
    {
        Console.WriteLine("Invalid choice!");
    }
}
while(true);

