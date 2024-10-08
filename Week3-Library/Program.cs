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

        // Create new instances of the Member class
        // These new members are created using the
        // Member constructor in the Members class
        Members member = new Members(1, "John Smith", "1 High Street", 0790090090);
        Members member1 = new Members(2, "Mary Jones", "102 Garden Road", 0790345666);

        Console.WriteLine("Current library members");
        member.DisplayInfo();
        member1.DisplayInfo();



    }
}
