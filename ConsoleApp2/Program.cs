namespace ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        Book myBook = new Book("hmmm", "feqf", 24);
        Console.WriteLine("Welcome to our E-Library");
        Console.WriteLine("This are the Books that are available");
        Console.WriteLine(myBook.Title);
        Console.WriteLine(myBook.Issue());
        Console.WriteLine(myBook.Issue());
        Console.WriteLine(myBook.Issue());
        Console.WriteLine(myBook.ReturnBook());
        Console.WriteLine(myBook.Issue());
        Console.WriteLine(myBook.ReturnBook());
        Console.WriteLine(myBook.ReturnBook());
        Console.WriteLine(myBook.ReturnBook());
    }

}