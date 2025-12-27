using LibraryApp.Models;

class Program
{
    static void Main()
    {
        Library library = new Library();

        Book book1 = new Book(
            "Clean Code",
            "Robert C. Martin",
            "9780132350884"
        );

        Book book2 = new Book(
            "C# in Depth",
            "Jon Skeet",
            "9781617294532"
        );

        library.AddBook(book1);
        library.AddBook(book2);

        library.BorrowBook("Clean Code");
        library.BorrowBook("Clean Code"); // دوباره امتحان می‌کنیم

        library.ReturnBook("Clean Code");
        library.BorrowBook("Clean Code");
    }
}