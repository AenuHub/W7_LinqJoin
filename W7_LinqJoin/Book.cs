namespace W7_LinqJoin;

public class Book
{
    public int BookID { get; set; }
    public string Title { get; set; }
    public int AuthorID { get; set; }
    
    public Book(int bookID, string title, int authorID)
    {
        BookID = bookID;
        Title = title;
        AuthorID = authorID;
    }
}