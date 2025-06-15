
using System;

public class ReflectionActivity : Activity
{
    private string[] _prompts = {
        "Think of a time when you overcame a challenge.",
        "Think of a moment where you felt truly at peace."
    };

    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "How can you apply this experience to your life today?"
    };

    public ReflectionActivity()
    {
        SetName("Reflection");
        SetDescription("This activity will help you reflect on meaningful experiences in your life.");
    }

    public override void PerformActivity()
    {
        DisplayStartingMessage();
        Random rnd = new Random();
        string prompt = _prompts[rnd.Next(_prompts.Length)];
        Console.WriteLine(prompt);
        Console.WriteLine("Press Enter when you have something in mind.");
        Console.ReadLine();
        Console.WriteLine("Now ponder the following questions:");
        Thread.Sleep(3000);

        foreach (string question in _questions)
        {
            Console.WriteLine(question);
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}
