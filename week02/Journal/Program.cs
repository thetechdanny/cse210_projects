using System;

// For creativity, I added a field (author) to the Entry class to track who wrote each entry.
// I also added a separator line in the Display method of Entry for better readability.

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");

                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    Console.Write("Author name: ");
                    string author = Console.ReadLine();

                    Entry newEntry = new Entry(prompt, response, author);
                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry added.");
                    break;

                case "2":
                    Console.WriteLine("\nJournal Entries:");
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}