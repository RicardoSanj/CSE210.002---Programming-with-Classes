using System;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name} Activity");
        Console.WriteLine(_description);
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);
        PerformActivity();
        End();
    }

    protected abstract void PerformActivity();

    protected void End()
    {
        Console.WriteLine("Good job!");
        ShowSpinner(2);
        Console.WriteLine($"You completed {_name} Activity for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected int GetDuration() => _duration;

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\" };
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < end)
        {
            Console.Write(spinner[i % 4]);
            Thread.Sleep(250);
            Console.Write("");
            i++;
        }
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write(" ");
        }
    }
}