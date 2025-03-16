using System.IO.Compression;

public class Comment
{
    string _username;
    string _text;

    public Comment(string username, string text)
    {
        _username = username;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"- {_username}: {_text}");
    }
}