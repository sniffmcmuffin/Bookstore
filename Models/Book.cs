using System.Reflection;

namespace Bookstore.Models;

public class Book
{
    public Book()
    {
        Title = null!;
        Author = null!;
        Isbn = 0;
    }
    public Book(string title, string author, int isbn)
    {
        Title = title;
        Author = author;
        Isbn = isbn;    
    }
    public string Title { get; set; } 
    public string Author { get; set; }
    public int Isbn { get; set; } // Samma sak som id
}




