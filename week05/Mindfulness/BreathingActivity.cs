using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        SetName("Breathing");
        SetDescription("This activity will help you relax by walking you through breathing in and out slowly.");
        SetDuration(60);
    }

    public void Run()
    {
        DisplayStartingMessage();
        int cycles = GetDuration() / 10; 
        for (int i = 0; i < cycles; i++)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Now breathe out... ");
            ShowCountDown(5);
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }
}