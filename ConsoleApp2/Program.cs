namespace ConsoleApp2;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public decimal Price { get; set; }
    private bool IsAvilable { get; set; }  = true;

    public Book(String title, String author, decimal price)
    {
        Title = title;
        Author = author;
        Price = price;
    }
    
    public String Issue()
    {
        if (IsAvilable)
        {
            IsAvilable = false;
            return "Book have been Issued Successfully";
        }
        
        return "Book is not Available";
        
    }

    public String ReturnBook()
    {
        if (IsAvilable)
        {
            return"Book is already Exist";
        }
        
        IsAvilable = true;
        return"Book have been successfully returned" ;
    }
}

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