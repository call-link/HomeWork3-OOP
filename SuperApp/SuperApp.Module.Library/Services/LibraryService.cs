using SuperApp.Module.Library.Models;

namespace SuperApp.Module.Library.Services
{
    public class LibraryService
    {
        private readonly List<Book> _books = new();

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public IEnumerable<Book> GetAll()
        {
            return _books;
        }
    }
}
