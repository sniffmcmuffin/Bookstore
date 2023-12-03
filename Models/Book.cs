using System.Reflection;
using Bookstore.Interfaces;

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

public class BasicBook : IBook
{
    public string Title { get; set; } = null!;
}

public class DetailedBook : IBook
{
    public string Title { get; set; } = null!;
    public string Author { get; set; } = null!;
    public string Type { get; set; } = null!;
    public int Isbn { get; set; }
}




