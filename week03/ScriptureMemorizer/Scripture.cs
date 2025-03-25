using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private static Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        this._reference = reference;
        _words = new List<Word>();

        foreach (var word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords()
    {
        List<Word> shownWords = _words.Where(word => !word.IsHidden()).ToList();

        if (shownWords.Any())
        {
            int i = _random.Next(shownWords.Count);
            shownWords[i].Hide();
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetReference()}: {string.Join(" ", _words.Select(word => word.GetDisplayText()))}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }

    public static Scripture GetScripture(string file)
    {
        string[] lines = File.ReadAllLines(file);
        lines = lines.Skip(1).ToArray();
        string randomLine = lines[_random.Next(lines.Length)];
        string[] parts = randomLine.Split(",");

        string book = parts[0];
        int chapter = int.Parse(parts[1]);
        int startVerse = int.Parse(parts[2]);
        int endVerse = int.Parse(parts[3]);
        string text = parts[4];

        Reference reference = new Reference(book, chapter, startVerse, endVerse);
        return new Scripture(reference, text);
    }
}