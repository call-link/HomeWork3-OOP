using System.Data.Common;
using SuperApp.Core.Modules;
using SuperApp.Module.Library.Models;
using SuperApp.Module.Library.Services;

namespace SuperApp.Module.Library;

public class LibraryModule : IModule
{
    public string Name => "Library";

    private readonly LibraryService _libraryService = new();

    public void Register() { }

    public void ShowMenu()
    {
        WriteLine("[1]- Add Book");
        WriteLine("[2]- Show Books");
        WriteLine("[3]- Borrow Book");
        WriteLine("[4]- Edit Book");

        var input = ReadLine();

        if (input == "1")
            AddBook();
        else if (input == "2")
            ShowBooks();
        else if (input == "3")
            BorrowBook();
    }

    private void AddBook()
    {
        Write("Title: ");
        var title = ReadLine();

        Write("Writer: ");
        var writer = ReadLine();

        Write("CountBook: ");
        var countBook = int.Parse(ReadLine());


        _libraryService.AddBook(new Book
        {
            Title = title,
            Wtiter = writer,
            CountBook = countBook
        });
    }

    private void ShowBooks()
    {
        foreach (var book in _libraryService.GetAll())
        {
            WriteLine($"‌book Ttitle : {book.Title} - Book owner :{book.Wtiter} - Book Count : {book.CountBook}");
        }
        WriteLine("Please select key ...");
        ReadKey();
    }

    // private void BorrowBook()
    // {
    //     WriteLine("Please give me youre title book :");
    //     var title = ReadLine();
    //     _libraryService.BorrowBook(title,count);
    // }
    private void BorrowBook()
    {
        WriteLine("Please give me your book title:");
        var title = ReadLine();

        WriteLine("How many count do you want to borrow?");
        int count = int.Parse(ReadLine());

        var success = _libraryService.BorrowBook(title, count);

        if (!success)
        {
            WriteLine("Borrow failed. Book not found or not enough count.");
            ReadKey();
        }
        else
        {
            WriteLine("Borrow successfully done.");
        }
        ReadKey();
    }

}

