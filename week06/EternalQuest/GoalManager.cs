using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\n==== Eternal Quest ====");
            DisplayPlayerInfo();

            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": RecordEvent(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": return;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nCurrent Score: {_score}\n");
    }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        Console.WriteLine("\nYour Goals:");
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nSelect goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string desc = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        if (choice == "1")
        {
            newGoal = new SimpleGoal(name, desc, points);
        }
        else if (choice == "2")
        {
            newGoal = new EternalGoal(name, desc, points);
        }
        else if (choice == "3")
        {
            Console.Write("Enter target count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            newGoal = new ChecklistGoal(name, desc, points, target, bonus);
        }

        if (newGoal != null)
        {
            _goals.Add(newGoal);
            Console.WriteLine("Goal created successfully!");
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record.");
            return;
        }

        ListGoalDetails();
        Console.Write("\nWhich goal did you accomplish? (Enter number): ");
        int choice = int.Parse(Console.ReadLine());

        if (choice > 0 && choice <= _goals.Count)
        {
            int earned = _goals[choice - 1].RecordEvent();
            _score += earned;
            Console.WriteLine($"You earned {earned} points!");
        }
    }

    public void SaveGoals()
    {
        Console.Write("\nEnter a name for your save file (without extension): ");
        string fileName = Console.ReadLine();

        
        string filePath = fileName.EndsWith(".txt") ? fileName : fileName + ".txt";

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine($"\nGoals saved successfully to {filePath}");
    }


    public void LoadGoals()
    {
        Console.Write("\nEnter the name of the file to load (without extension): ");
        string fileName = Console.ReadLine();

        
        string filePath = fileName.EndsWith(".txt") ? fileName : fileName + ".txt";

        if (!File.Exists(filePath))
        {
            Console.WriteLine($"\nFile \"{filePath}\" not found. Please check the name and try again.");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines(filePath);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string type = parts[0];
            string[] data = parts[1].Split(',');

            switch (type)
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(
                        data[0], data[1],
                        int.Parse(data[2]),
                        bool.Parse(data[3])
                    ));
                    break;

                case "EternalGoal":
                    _goals.Add(new EternalGoal(
                        data[0], data[1],
                        int.Parse(data[2])
                    ));
                    break;

                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(
                        data[0], data[1],
                        int.Parse(data[2]),
                        int.Parse(data[4]),
                        int.Parse(data[3]),
                        int.Parse(data[5])
                    ));
                    break;
            }
        }

        Console.WriteLine($"\nGoals loaded successfully from \"{filePath}\"!");
    }
}
