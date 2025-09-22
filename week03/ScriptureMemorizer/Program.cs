using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        string scriptureText = "For God so loved the world that he gave his one and only Son that whosoever believes in Him should not perish but have everlasting life";
        
        var wordsList = new List<Words>();
        foreach (var word in scriptureText.Split(' '))
        {
            wordsList.Add(new Words(word));
        }

        Scripture scripture = new Scripture(reference, wordsList);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            if (!scripture.IsCompletelyHidden())
            {
                scripture.HideRandomWords(1);
                
            }
            else
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.Write("All words are hidden. Program will exit.");
                break;
            }
        }
    }
}