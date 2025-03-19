using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _inputText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_inputText}");
    }
}