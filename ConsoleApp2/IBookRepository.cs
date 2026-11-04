namespace ConsoleApp2;

public interface IBookRepository
{
    public Book Save(Book book);
    public Book? GetById(Guid id);
    public List<Book> GetAll();
}