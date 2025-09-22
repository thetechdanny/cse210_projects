using System;
using System.Collections.Generic;
using System.Linq;
class Scripture
{
    private Reference _reference;
    private List<Words> _words;

    public Scripture(Reference reference, List<Words> words)
    {
        _reference = reference;
        _words = words;
    }

    public void HideRandomWords(int count)
    {
        var rand = new Random();
        int hidden = 0;
        while (hidden < count)
        {
            int i = rand.Next(_words.Count);
            if (!_words[i].IsHidden())
            {
                _words[i].Hide();
                hidden++;
            }
        }
    }

    public string GetDisplayText()
    {
        string refText = _reference.GetDisplayText();
        string text = "";
        foreach (var word in _words)
        {
            text += word.GetDisplayText() + " ";
        }
        return refText + " " + text.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}