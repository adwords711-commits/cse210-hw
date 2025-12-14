using System;
public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int CountComments()
    {
        return _comments.Count;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds} seconds");
        Console.WriteLine($"Comments ({CountComments()})");        
    
        foreach (Comment c in _comments)
        {
            c.DisplayComment();
        }
        Console.WriteLine();
    }


}