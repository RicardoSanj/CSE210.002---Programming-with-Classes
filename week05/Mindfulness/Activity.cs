
using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public void SetName(string name) => _name = name;
    public void SetDescription(string description) => _description = description;
    public void SetDuration(int duration) => _duration = duration;
    public int GetDuration() => _duration;

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name} Activity");
        Console.WriteLine(_description);
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Good job! You completed {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        Console.Write("Processing: ");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write(" ");
        }
        Console.WriteLine();
    }

    public virtual void PerformActivity() { }
}
