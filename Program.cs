// Här är main, huvudprogrammet.
//
// Services inkluderar models som har en klass Book.
// Klassen Book innehåller relevant data. 
// StoreMenu är en loop med olika alternativ.

using Bookstore.Services;

class Program
{    
    static void Main()
    {
        Console.WindowWidth = 150; // För loggan.

        var bookService = new BookService(); // Skapa en instans iom det är objektorienterad. Tog lång tid lista ut felet.
        var storeMenu = new StoreMenu(bookService); // Skapar en instans av menyn.
               
        storeMenu.Run(); // Starta upp meny loop.
    }
}
