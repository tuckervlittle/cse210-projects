using System;
using System.Net.Http.Headers;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

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
        Random random = new Random();
        List<Word> shownWords = _words.Where(word => !word.IsHidden()).ToList();

        if (shownWords.Any())
        {
            int i = random.Next(shownWords.Count);
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
}