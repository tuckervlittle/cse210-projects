using System;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthSeconds;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lengthSeconds = length;
        _comments = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthSeconds}");
        foreach (var comment in _comments)
        {
            Console.WriteLine($"    {comment.GetComment()}");
        }
        Console.WriteLine($"Number of comments: {_comments.Count()}");
    }
}