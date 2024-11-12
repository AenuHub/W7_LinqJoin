namespace W7_LinqJoin;

public class Author
{
    public int AuthorID { get; set; }
    public string Name { get; set; }

    public Author(int authorId, string name)
    {
        AuthorID = authorId;
        Name = name;
    }
}