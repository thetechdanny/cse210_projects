using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input your grade score: ");
        int gradeScore = int.Parse(Console.ReadLine());

        char grade = ' ';

        if (gradeScore >= 90)
        {
            grade = 'A';
        }

        else if (gradeScore >= 80)
        {
            grade = 'B';
        }
        else if (gradeScore >= 70)
        {
            grade = 'C';
        }
        else if (gradeScore >= 60)
        {
            grade = 'D';
        }
        else
        {
            grade = 'F';
        }

        char gradeSign = ' ';
        int lastDigit = gradeScore % 10;

        if (lastDigit >= 7 && grade != 'A' && grade != 'F')
        {
            gradeSign = '+';
        }

        else if (lastDigit <= 3 && grade != 'F')
        {
            gradeSign = '-';
        }

        else
        {
            gradeSign = ' ';
        }

        Console.WriteLine($"Your grade is {grade}{gradeSign}");

        if (gradeScore >= 70)
        {
            Console.WriteLine("Congratulations! You passed the benchmark for this course.");
        }

        else
        {
            Console.WriteLine("Sorry, you did not pass the benchmark for this course. Put in more effort in your studies!");
        }
    }
}