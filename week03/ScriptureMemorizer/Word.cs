using System;

class Words
{
    private string _text;
    private bool _isHidden;

    public Words(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
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