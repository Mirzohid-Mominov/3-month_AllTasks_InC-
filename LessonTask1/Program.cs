public class Program
{
    public void Main(string[] args)
    {

    }
}

public struct Book
{
    
    public readonly long Id { get; }
    public readonly string Name { get; }
    public readonly string Publisher { get; }
    public Book(long id)
    {
        Id = id;
    }
}