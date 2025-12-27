using System.Collections.Generic;

namespace LibraryApp.Models;

public class Library
{
    private List<Book> books = new();

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Book '{book.Title}' adeded to the library.");
    }

    public void BorrowBook(string title)
    {
        Book? book = books.Find(b => b.Title == title);

        if (book == null)
        {
            Console.WriteLine("Book not found !");
            return;
        }

        book.Borrow();
    }

    public void ReturnBook(string title)
    {
        Book? book = books.Find(b => b.Title == title);

        if (book == null)
        {
            Console.WriteLine("Book not found !");
            return;
        }

        book.Return();
    }
}
