using System.Transactions;

public class Video
{
    string _title;
    string _author;
    int _length;
    List<Comment> _comments;

    public Video(string title, string author, int length)

    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideo()
    {
        Console.WriteLine(_title);
        Console.WriteLine($"by {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine("");
    }

}