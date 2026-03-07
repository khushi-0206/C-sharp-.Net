using Assessment_7_March.Models;

namespace Assessment_7_March.Repository
{
    public class SqlBookRepository : IBookRepository
    {
        private readonly LibraryDbContext _context;

        public SqlBookRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public List<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        public Book GetBookById(int id)
        {
            return _context.Books.FirstOrDefault(b => b.BookId == id);
        }

        public bool AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateBook(Book book)
        {
            var existingBook = _context.Books.FirstOrDefault(b => b.BookId == book.BookId);

            if (existingBook != null)
            {
                existingBook.Title = book.Title;
                existingBook.Author = book.Author;
                existingBook.Price = book.Price;

                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public bool DeleteBook(int id)
        {
            var book = _context.Books.FirstOrDefault(b => b.BookId == id);

            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
