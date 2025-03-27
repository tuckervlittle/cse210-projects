using System;

public class Comment
{
    private string _userName;
    private string _text;

    public Comment(string user, string text)
    {
        _userName = user;
        _text = text;
    }
    public string GetComment()
    {
        return $"{_userName}: {_text}";
    }
}