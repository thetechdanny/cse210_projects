using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public int GetCount()
    {
        return _count;
    }

    public void SetCount(int value)
    {
        _count = value;
    }

    public List<string> GetPrompts()
    {
        return _prompts;
    }

    public void SetPrompts(List<string> value)
    {
        _prompts = value;
    }

    public ListingActivity() : base()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 60;
        _count = 0;
        _prompts = new List<string> {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"-> {prompt} ---\n");
        ShowCountDown(3);
        List<string> responses = GetListFromUser();
        _count = responses.Count;
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("-> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                responses.Add(input);
        }
        return responses;
    }
} 