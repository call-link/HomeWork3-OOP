namespace LibraryApp.Models;



public class Book
{
    public string Title { get; }
    public string Author { get; }
    public string ISBN { get; }
    public bool IsAvailable { get; private set; }

    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        IsAvailable = true; // کتاب در ابتدا موجود است
    }

    public void Borrow()
    {
        if (!IsAvailable)
        {
            Console.WriteLine($"Book '{Title}' Status : Not Available !");
            return;
        }

        IsAvailable = false;
        Console.WriteLine($"Book '{Title}' status : Barrowed .");
    }

    public void Return()
    {
        IsAvailable = true;
        Console.WriteLine($"Book '{Title}' status : Returned.");
    }
}


