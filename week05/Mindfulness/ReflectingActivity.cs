using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    
    public List<string> GetPrompts()
    {
        return _prompts;
    }

    public void SetPrompts(List<string> value)
    {
        _prompts = value;
    }

    public List<string> GetQuestions()
    {
        return _questions;
    }

    public void SetQuestions(List<string> value)
    {
        _questions = value;
    }

    public ReflectingActivity() : base()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience.";
        _duration = 60;
        _prompts = new List<string> {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string> {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {prompt} ---\n");
        ShowSpinner(8);
        DisplayQuestions();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
    }

    // Display all questions with spinner between each
    public void DisplayQuestions()
    {
        int secondsPerQuestion = 5;
        List<string> usedQuestions = new List<string>();
        int numQuestions = Math.Min(4, _questions.Count); // Show up to 4 questions
        Random rand = new Random();
        for (int i = 0; i < numQuestions; i++)
        {
            string question;
            do {
                question = GetRandomQuestion();
            } while (usedQuestions.Contains(question));
            usedQuestions.Add(question);
            Console.WriteLine($"> {question}");
            ShowSpinner(secondsPerQuestion);
        }
    }
}