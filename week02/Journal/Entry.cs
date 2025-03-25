using System;
using System.Data.Common;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _inputText;
    public string _feeling;

    public Entry(string promptText, string inputText, string feeling)
    {
        _date = DateTime.Now.ToString("d");
        _promptText = promptText;
        _inputText = inputText;
        _feeling = feeling;
    }

    public Entry(string date, string promptText, string inputText, string feeling)
    {
        _date = date;
        _promptText = promptText;
        _inputText = inputText;
        _feeling = feeling;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Feeling: {_feeling} - Prompt: {_promptText}");
        Console.WriteLine($"{_inputText}");
        Console.WriteLine();
    }
}