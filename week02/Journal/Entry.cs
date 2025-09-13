using System;

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;
    private string _author;

    public Entry(string promptText, string entryText, string author)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        _promptText = promptText;
        _entryText = entryText;
        _author = author;
    }

    public string GetSaveFormat()
    {
        // Use "|" separator for saving
        return $"{_date}|{_promptText}|{_entryText}|{_author}";
    }

    public static Entry FromSaveFormat(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length >= 4)
        {
            Entry entry = new Entry(parts[1], parts[2], parts[3]);
            entry._date = parts[0]; // preserve saved date
            return entry;
        }
        return null;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine("<.............................................>");
    }
}
