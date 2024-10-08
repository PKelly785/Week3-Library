

namespace Week3_Library
{
    class Book
    {
        // properties
       private string Title;
       private string Author;
       private string ISBN;
       private int Pages;

        // Title property to allow access 
        // to the title private variable
        public string title
        {
            get { return title; } // get method
            set { title = value; } // set method
        }
        public string author
        {
            get { return author; }
            set { author = value; }
        }   
        public string isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public int pages
        {
            get { return pages; }
            set { pages = value; }
        }

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
