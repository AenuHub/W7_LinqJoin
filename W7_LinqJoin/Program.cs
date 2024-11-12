using W7_LinqJoin;

public class Program
{
    static void Main(string[] args)
    {
        List<Author> authors = new List<Author>()
        {
            new Author(1, "Orhan Pamuk"),
            new Author(2, "Elif Şafak"),
            new Author(3, "Ahmet Ümit")
        };

        List<Book> books = new List<Book>()
        {
            new Book(1, "Kar", 1),
            new Book(2, "İstanbul", 1),
            new Book(3, "10 Minutes 38 Seconds in This Strange World", 2),
            new Book(4, "Beyoğlu Rapsodisi", 3)
        };
        
        var result = from author in authors
            join book in books on author.AuthorID equals book.AuthorID
            select new { author.Name, book.Title };

        foreach (var item in result)
        {
            Console.WriteLine($"Book Title: {item.Title} -> Author: {item.Name}");
        }
        
        Console.ReadKey();
    }
}