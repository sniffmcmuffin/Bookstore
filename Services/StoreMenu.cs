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
                DisplayLogo();
                DisplayMenu();
                string? userInput = Console.ReadLine();
                MenuOptions(userInput);
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }

        private void DisplayLogo() // Skoj
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logo.txt");

            Console.OutputEncoding = System.Text.Encoding.UTF8; // Set console encoding

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                Console.WriteLine("Contents of the text file:\n");

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("The specified file does not exist.");
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
