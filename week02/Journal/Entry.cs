using System;
using System.Data.Common;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _inputText;

    public Entry(string promptText, string inputText)
    {
        _date = DateTime.Now.ToString("d");
        _promptText = promptText;
        _inputText = inputText;
    }

    public Entry(string date, string promptText, string inputText)
    {
        _date = date;
        _promptText = promptText;
        _inputText = inputText;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_inputText}");
        Console.WriteLine();
    }
}