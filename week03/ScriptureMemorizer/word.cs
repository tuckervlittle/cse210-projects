using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        this._text = text;
        this._isHidden = false;
    }
    public void Hide()
    {
        this._isHidden = true;
    }
    public void Show()
    {
        this._isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}