using SuperApp.Core.Modules;
using SuperApp.Module.Library.Models;
using SuperApp.Module.Library.Services;

namespace SuperApp.Module.Library
{
    public class LibraryModule : IModule
    {
        public string Name => "Library";

        private readonly LibraryService _libraryService = new();

        public void Register() { }

        public void ShowMenu()
        {
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Show Books");

            var input = Console.ReadLine();

            if (input == "1")
                AddBook();
            else if (input == "2")
                ShowBooks();
        }

        private void AddBook()
        {
            Console.Write("Title: ");
            var title = Console.ReadLine();

            Console.Write("Author: ");
            var author = Console.ReadLine();

            Console.Write("ISBN: ");
            var isbn = Console.ReadLine();

            _libraryService.AddBook(new Book
            {
                Title = title,
                Author = author,
                Isbn = isbn
            });
        }

        private void ShowBooks()
        {
            foreach (var book in _libraryService.GetAll())
            {
                Console.WriteLine($"{book.Title} - {book.Author}");
            }

            Console.ReadKey();
        }
    }
}
