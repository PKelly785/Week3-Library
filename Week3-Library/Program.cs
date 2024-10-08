class Book
{
    string Title;
    string Author;
    string ISBN;
    int Pages;

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
        Book book = new Book();
        book.Title = "C# for beginners";
        book.Author = "Bill Gates";
        book.ISBN = "1234567";
        book.Pages = 97;

        Book book2 = new Book();
        book2.Title = "C# Methods and Classes";
        book2.Author = "Microsoft";
        book2.ISBN = "7654321";
        book2.Pages = 129;

        // Output book information to the console
        book.DisplayInfo();
        book2.DisplayInfo();


    }
}
