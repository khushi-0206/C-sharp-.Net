public class Program
{
    public static Dictionary<string,Book> bookDetails = new Dictionary<string, Book>();
    public static void Main()
    {
        bookDetails.Add("BK01",new Book{BookId="BK01",Title="JavaBook",Price=750,Stock=20});
        bookDetails.Add("BK02",new Book{BookId="BK02",Title="PythonBook",Price=1750,Stock=10});
        bookDetails.Add("BK03",new Book{BookId="BK03",Title="CBook",Price=850,Stock=40});
        bookDetails.Add("BK04",new Book{BookId="BK04",Title="Computer networks",Price=950,Stock=15});
        bookDetails.Add("BK05",new Book{BookId="BK05",Title="Operating System",Price=750,Stock=20});
        

        do
        {
            Console.WriteLine("1. Display book details");
            Console.WriteLine("2. Update Price");
            Console.WriteLine("3. Update Stock");
            Console.WriteLine("4. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());
            BookUtility buObj = new BookUtility();
            switch (choice)
            {
                case 1:
                {
                    
                    Console.Write("Enter id: ");
                    string id = Console.ReadLine();
                    Book res = buObj.GetBookDetails(id);
                    Console.WriteLine($"{res.BookId} {res.Title} {res.Price} {res.Stock}");
                    break; 
                }
                case 2:
                {
                    Console.Write("Enter id: ");
                    string id = Console.ReadLine();

                    Console.Write("Enter Price: ");
                    int price = Convert.ToInt32(Console.ReadLine());
                    buObj.UpdateBookPrice(id,price);
                    Console.WriteLine("Updated Price: "+price);

                    break; 
                }
                case 3:
                {
                    Console.Write("Enter id: ");
                    string id = Console.ReadLine();

                    Console.Write("Enter Stock: ");
                    int stock = Convert.ToInt32(Console.ReadLine());
                    buObj.UpdateBookStock(id,stock);
                    Console.WriteLine("Updated Price: "+stock);
                    break; 
                }
                case 4:
                {
                    Console.WriteLine("Exiting..");
                    return; 
                }
                default:
                {
                    Console.WriteLine("Invalid choice");
                    break; 
                }
            }
            
        }
        while(true);
    }
}