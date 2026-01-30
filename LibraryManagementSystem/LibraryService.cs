using System;
using System.Collections.Generic;
using System.Linq;
using LibraryManagement.Models;

namespace LibraryManagement.Services
{
    public class LibraryService
    {
        private List<Book> books = new List<Book>();
        private int nextId = 1;

        // ===== ADD =====
        public void AddBook(string name, string author, string publisher, double price)
        {
            var book = new Book
            {
                Id = nextId++,
                Name = name,
                Author = author,
                Publisher = publisher,
                Price = price
            };

            books.Add(book);
            Console.WriteLine("Book added");
        }

        // ===== UPDATE =====
        public void UpdateBook(int id, string name, string author, string publisher, double price)
        {
            var book = books.FirstOrDefault(x => x.Id == id);
            if (book == null)
            {
                Console.WriteLine("Book not found");
                return;
            }

            book.Name = name;
            book.Author = author;
            book.Publisher = publisher;
            book.Price = price;

            Console.WriteLine(" Book updated");
        }

        // ===== DELETE =====
        public void DeleteBook(int id)
        {
            var book = books.FirstOrDefault(x => x.Id == id);
            if (book == null)
            {
                Console.WriteLine("Book not found");
                return;
            }

            books.Remove(book);
            Console.WriteLine("Book deleted");
        }

        // ===== VIEW =====
        public List<Book> GetAllBooks() => books;

        // ===== SEARCH =====
        public IEnumerable<Book> SearchByName(string key)
        {
            return books.Where(b => b.Name.Contains(key, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Book> SearchByPublisher(string key)
        {
            return books.Where(b => b.Publisher.Contains(key, StringComparison.OrdinalIgnoreCase));
        }

        // ===== PRICE FILTER =====
        public Book GetHighestPriceBook()
        {
            return books.OrderByDescending(b => b.Price).FirstOrDefault();
        }

        public Book GetLowestPriceBook()
        {
            return books.OrderBy(b => b.Price).FirstOrDefault();
        }

        // ===== dynamic DEMO =====
        public dynamic GetDynamicBookView(Book b)
        {
            dynamic obj = new System.Dynamic.ExpandoObject();
            obj.Title = b.Name;
            obj.Writer = b.Author;
            obj.Cost = b.Price;
            return obj;
        }
    }
}
