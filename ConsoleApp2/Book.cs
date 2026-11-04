namespace ConsoleApp2;

public class Book
{
    private  String _title;
    public string Title
    {
        get { return _title;}
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Title cannot be null or empty");
            }

            _title =  value;
        }
    }
    private string _author;

    public string Author
    {
        get { return _author;}
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Author cannot be null or empty");
            }
            
            _author = value;
        }
    }
    private decimal _price;
    public decimal Price
    {
        get { return _price;}
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Price cannot be negative");
            }
            _price = value;
        }
        
    }
    private bool IsAvilable { get; set; }  = true;
    
    public Guid Id { get; set; } = Guid.NewGuid();
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