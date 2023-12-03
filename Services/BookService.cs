using System;
using Bookstore.Models;
using Bookstore.Interfaces;
using static Bookstore.Models.Book;

namespace Bookstore.Services;

public class BookService
{
    // Deklarera listan med böcker
    private List<IBook> bookList = new List<IBook>();
       
    public void AddBook()  // Lägg till en ny bok i listan
    {
        var book = new DetailedBook();

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

        Console.WriteLine("Ange typ av bok: ");
        string? typeInput = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(typeInput))
        {
            book.Type = typeInput;
        }
        else
        {
            Console.WriteLine("Välj något av lånebok/ljudbok/ebok/faktabok/skönlitteratur");
        }

        Console.WriteLine("Ange ISBN nummer: ");

        if (int.TryParse(Console.ReadLine(), out int isbn))
        {
   
            book.Isbn = isbn;
            bookList.Add(book); // Lägg till boken i listan.
            Console.WriteLine("Book added successfully.");
        }
    }

    public void ListBooks() // Visa böcker i listan
    {
        var count = bookList.Count;

        Console.WriteLine($"List of Books\n=-=-=-=-=-=-=\nThere are {count} books in store:\n");

        foreach (var b in bookList)
        {
            Console.WriteLine($"Title: {b.Title}");

            if (b is DetailedBook detailedBook)
            {
                Console.WriteLine($"Author: {detailedBook.Author}, Type: {detailedBook.Type}, ISBN: {detailedBook.Isbn}");
            }
        }
    }
}
