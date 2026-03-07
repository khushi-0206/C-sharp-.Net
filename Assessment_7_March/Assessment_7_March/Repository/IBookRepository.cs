using Assessment_7_March.Models;

namespace Assessment_7_March.Repository
{
    public interface IBookRepository
    {
        public List<Book> GetAllBooks();
        public Book GetBookById(int id);
        public bool AddBook(Book book);
        public bool DeleteBook(int id);
        public bool UpdateBook(Book book);
    }
}
