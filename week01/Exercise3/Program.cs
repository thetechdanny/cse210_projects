using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {

        string response = "yes";

        while (response != "no")
        {
            if (response == "yes")
            {
                Random randomGenerator = new Random();
                int number = randomGenerator.Next(1, 101);

                int userGuess = 0;
                int guessCount = 0;

                while (userGuess != number)
                {
                    Console.Write("What is your guess? ");
                    userGuess = Convert.ToInt32(Console.ReadLine());

                    if (userGuess > number)
                    {
                        Console.WriteLine("Wrong! Guess lower");
                    }

                    else if (userGuess < number)
                    {
                        Console.WriteLine("Wrong! Guess higher");
                    }

                    else
                    {
                        Console.WriteLine("Correct! You guessed it right!!!");
                    }

                    guessCount += 1;
                }

                Console.WriteLine($"You made {guessCount} guesses");
                Console.Write("Do you want to play again? ");
                response = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter 'yes' or 'no'");
                response = Console.ReadLine();

            }
        }
        Console.WriteLine("Thanks for playing!");

    }
}