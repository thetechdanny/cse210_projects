using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Daniel Kalu", "C# Inheritance");
        Console.WriteLine(assignment.GetSummary());
        
        Console.WriteLine("...............................................................");

        MathAssignment mathassignment = new MathAssignment("Daniel Kalu", "C# Inheritance", "Section 7.3", "Problems 1-20");
        Console.WriteLine(mathassignment.GetHomeworkList());

        Console.WriteLine("...............................................................");

        WritingAssignment writingassignment = new WritingAssignment("Daniel Kalu", "C# Inheritance", "C# Inheritance and Accessifiers");
        Console.WriteLine(writingassignment.GetWritingInformation());
    }
}