using System;
using System.Configuration.Assemblies;

class Program
{

    static void DisplayWelcome()
    {
        Console.WriteLine("Hello World!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your username: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favourite number: ");
        int userNumber = Convert.ToInt32(Console.ReadLine());
        return userNumber;
    }
    static int SquareNumber(int number)
    {
        int squareNumber = number * number;
        return squareNumber;
    }

    static string DisplayResult(string userName, int squareNumber)
    {
        string result = ($"{userName}, the square of your number is {squareNumber}");
        return result;
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        string result = DisplayResult(userName, squaredNumber);
        Console.WriteLine(result);
    }
}