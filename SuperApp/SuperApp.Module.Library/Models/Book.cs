namespace SuperApp.Module.Library.Models;

public class Book
{
    public string Title { get; set; }
    public string Wtiter { get; set; }
    public int CountBook { get; set; } // برای نگهداری تعداد کتاب هایی که داریم
    // public bool IsAvailable { get; private set; } = true;

    // public void Borrow()
    // {
    //     IsAvailable = false;
    // }
}


