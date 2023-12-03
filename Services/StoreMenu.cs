using Bookstore.Models;
using System;

namespace Bookstore.Services
{
    // Huvudmeny
    internal class StoreMenu
    {
        private readonly BookService bookService;

        public StoreMenu(BookService bookService)
        {
            this.bookService = bookService;
        }

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                DisplayMenu();
                string? userInput = Console.ReadLine();
                MenuOptions(userInput);
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }

        private void DisplayMenu()
        {
            Console.WriteLine("Simple Console Menu");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. List Books");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");
        }

        private void MenuOptions(string? choice)
        {
            if (choice != null)
            {
                switch (choice)
                {
                    case "1":
                        AddBook();
                        break;

                    case "2":
                        GetBooks();
                        break;

                    case "3":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }
        
        private void AddBook()
        {
            Console.WriteLine("Adding a new book:");
            bookService.AddBook();
        }

        public void GetBooks()
        {
            bookService.ListBooks();
        }
    }
}
