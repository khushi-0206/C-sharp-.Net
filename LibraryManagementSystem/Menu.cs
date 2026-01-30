using System;
using System.Linq;
using LibraryManagement.Services;

namespace LibraryManagement.UI
{
    public class Menu
    {
        private LibraryService service = new LibraryService();

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\n====== LIBRARY SYSTEM ======");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. User");
                Console.WriteLine("3. Exit");
                Console.Write("Choice: ");

                int ch = Convert.ToInt32(Console.ReadLine());

                if (ch == 1) AdminMenu();
                else if (ch == 2) UserMenu();
                else return;
            }
        }

        private void AdminMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- ADMIN MENU ---");
                Console.WriteLine("1 Add Book");
                Console.WriteLine("2 Update Book");
                Console.WriteLine("3 Delete Book");
                Console.WriteLine("4 View Books");
                Console.WriteLine("5 Back");

                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1: AddBookUI(); break;
                    case 2: UpdateBookUI(); break;
                    case 3: DeleteBookUI(); break;
                    case 4: Show(service.GetAllBooks()); break;
                    case 5: return;
                }
            }
        }

        private void UserMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- USER MENU ---");
                Console.WriteLine("1 Browse");
                Console.WriteLine("2 Search Name");
                Console.WriteLine("3 Search Publisher");
                Console.WriteLine("4 Highest Price");
                Console.WriteLine("5 Lowest Price");
                Console.WriteLine("6 Back");

                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Show(service.GetAllBooks());
                        break;

                    case 2:
                        Console.Write("Name key: ");
                        Show(service.SearchByName(Console.ReadLine()));
                        break;

                    case 3:
                        Console.Write("Publisher key: ");
                        Show(service.SearchByPublisher(Console.ReadLine()));
                        break;

                    case 4:
                        ShowOne(service.GetHighestPriceBook());
                        break;

                    case 5:
                        ShowOne(service.GetLowestPriceBook());
                        break;

                    case 6:
                        return;
                }
            }
        }

        private void AddBookUI()
        {
            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("Author: ");
            var author = Console.ReadLine();

            Console.Write("Publisher: ");
            var pub = Console.ReadLine();

            Console.Write("Price: ");
            var price = Convert.ToDouble(Console.ReadLine());

            service.AddBook(name, author, pub, price);
        }

        private void UpdateBookUI()
        {
            Console.Write("ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("Author: ");
            var author = Console.ReadLine();

            Console.Write("Publisher: ");
            var pub = Console.ReadLine();

            Console.Write("Price: ");
            var price = Convert.ToDouble(Console.ReadLine());

            service.UpdateBook(id, name, author, pub, price);
        }

        private void DeleteBookUI()
        {
            Console.Write("ID: ");
            service.DeleteBook(Convert.ToInt32(Console.ReadLine()));
        }

        private void Show(System.Collections.Generic.IEnumerable<LibraryManagement.Models.Book> list)
        {
            if (!list.Any())
            {
                Console.WriteLine("No books found");
                return;
            }

            foreach (var b in list)
                ShowOne(b);
        }

        private void ShowOne(LibraryManagement.Models.Book b)
        {
            if (b == null)
            {
                Console.WriteLine("No data");
                return;
            }

            Console.WriteLine("--------------------");
            Console.WriteLine($"ID: {b.Id}");
            Console.WriteLine($"Name: {b.Name}");
            Console.WriteLine($"Author: {b.Author}");
            Console.WriteLine($"Publisher: {b.Publisher}");
            Console.WriteLine($"Price: {b.Price}");
        }
    }
}
