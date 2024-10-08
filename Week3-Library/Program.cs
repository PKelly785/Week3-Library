using Week3_Library;

class Program

{ 


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
