

namespace Week3_Library
{
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

       public void DisplayInfo()
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
    }
}
