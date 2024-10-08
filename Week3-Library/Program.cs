class Book
{
    // properties
    string Title;
    string Author;
    string ISBN;
    int Pages;

    // Constructor for book object
    public Book(string bookTitle, string bookAuthor, string bookISBN, int bookPages)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
        Pages = bookPages;
    }

    void DisplayInfo()
    {
        // Output the book information to the console
        Console.WriteLine("Book information");
        Console.WriteLine("------------");
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"book author: {Author}");
        Console.WriteLine($"book ISBN: {ISBN}");
        Console.WriteLine($"Amount of pages: {Pages}");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        //create a new instance of the book class
        Book book = new Book("C# for beginners","Bill Gates","1234567",200);

        // another instance
        // title = "Visual Studio 2022"
        //Author = "Microsoft"
        // ISBN = "7654321"
        // Pages 70
        Book book2 = new Book("Visual Studio 2022", "Microsoft", "7654321", 70);
        
        

        // Output book information to the console
        book.DisplayInfo();
        book2.DisplayInfo();
        


    }
}
