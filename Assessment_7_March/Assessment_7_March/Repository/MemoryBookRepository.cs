using Assessment_7_March.Models;

namespace Assessment_7_March.Repository
{
    public class MemoryBookRepository : IBookRepository
    {
        private static Dictionary<int, Book> _books = new Dictionary<int, Book>();
        public MemoryBookRepository()
        {
            _books = new Dictionary<int, Book>
            {
                { 1, new Book { BookId = 1, Title = "The Alchemist", Author = "Paulo Coelho", Price = 499 } },
                { 2, new Book { BookId = 2, Title = "Clean Code", Author = "Robert C. Martin", Price = 750 } },
                { 3, new Book { BookId = 3, Title = "The Pragmatic Programmer", Author = "Andrew Hunt", Price = 820 } },
                { 4, new Book { BookId = 4, Title = "Atomic Habits", Author = "James Clear", Price = 650 } },
                { 5, new Book { BookId = 5, Title = "Rich Dad Poor Dad", Author = "Robert Kiyosaki", Price = 550 } }
            };
        }
        public bool AddBook(Book book)
        {
            if (!_books.ContainsKey(book.BookId))
            {
                _books.Add(book.BookId, book);
                return true;
            }
            return false;
        }

        public bool DeleteBook(int id)
        {
            if (_books.ContainsKey(id))
            {
                _books.Remove(id);
                return true;
            }
            return false;
                
        }
        public bool UpdateBook(Book book)
        {
            if (_books.ContainsKey(book.BookId))
            {
                _books[book.BookId].Author = book.Author;
                _books[book.BookId].Title = book.Title;
                _books[book.BookId].Price = book.Price;
                return true;
            }
            return false;
        }

        public List<Book> GetAllBooks()
        {
            
            return _books.Values.ToList();
        }

        public Book GetBookById(int id)
        {
            if(_books.ContainsKey(id))
            {
                return _books[id];
            }
            return null;
        }
        
    }
}
