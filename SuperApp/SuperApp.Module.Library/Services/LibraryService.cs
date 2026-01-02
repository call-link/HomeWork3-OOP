using System.Timers;
using SuperApp.Module.Library.Models;

namespace SuperApp.Module.Library.Services;

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

    public bool BorrowBook(string title, int count)
    {
        var book = _books.FirstOrDefault(b => b.Title == title);

        if (book == null)
            return false;

        if (book.CountBook < count)
            return false;

        book.CountBook -= count;
        return true;
    }
}





// public bool BorrowBook(string title)
//     {
//         var book = _books.FirstOrDefault(b => b.Title == title);

//         if (book == null)
//         {
//             // WriteLine("This is book not find !");
//             // ReadKey();
//             return false;
//         }
//         else
//         {
//             // WriteLine($"Book find {book.Title} and count is {book.CountBook} .");
//             // WriteLine($"How meny count borrow this book ?");
//             int userNumberBorrow = int.Parse(ReadLine());
//             var result = book.CountBook - userNumberBorrow;
//             if (result < 0)
//             {
//                 // WriteLine("The proccess is failed , try again ...");
//                 // ReadKey();
//                 return false;
//             }
//             else
//             {
//                 book.CountBook = result;
//                 // WriteLine("Amanat is Successfully .");
//                 // ReadKey();
//                 return true;
//             }
//             // return true;
//         }
//     }