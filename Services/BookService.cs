using System;
using Bookstore.Models;

namespace Bookstore.Services;

public class BookService
{
    // Deklarera listan med böcker
    private List<Book> bookList = new List<Book>();
       
    public void AddBook()  // Lägg till en ny bok i listan
    {
        // Exempel 1
        // var book = new Book("hejsavens", "jimmy", 75685686);
        // Exempel 2
        // var book_2 = new Book
        // {
        //   Title = "sdfsgg",
        //  Author = "sgdfgdfgdfd",A
        //  Isbn = 3536356
        // };    

        // var bookService = new BookService();
        // bookService.Add();


        var book = new Book();

        Console.WriteLine("Ange bokens titel: ");
        string? titleInput = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(titleInput)) // Känns onödigt krångligt göra så här. Måste finnas bättre sätt.
        {
            book.Title = titleInput;
        }
        else
        {
            Console.WriteLine("Du måste fylla i något.");
        }

        Console.WriteLine("Ange författare: ");
        string? authorInput = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(authorInput))
        {
            book.Author = authorInput;
        }
        else
        {
            Console.WriteLine("Du måste fylla i något.");
        }

        Console.WriteLine("Ange ISBN nummer: ");

        if (int.TryParse(Console.ReadLine(), out int isbn))
        {
            book.Isbn = isbn;
            // AddBook();
            bookList.Add(book); // Lägg till boken i listan.
            Console.WriteLine("Book added successfully.");
        }
    }

    public void ListBooks() // Visa böcker i listan
    {
        var count = bookList.Count;

        Console.WriteLine($"List of Books\n=-=-=-=-=-=-=\nThere are {count} books in store:\n\n");
       
        foreach (var b in bookList)
        {
            Console.WriteLine($"Title: {b.Title}, Author: {b.Author}, ISBN: {b.Isbn}");
        }
    }
}
