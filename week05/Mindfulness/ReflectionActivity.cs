using System;
using System.Threading;

public class ReflectionActivity : Activity
{
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base(
        "Reflection Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
    )
    {
    }

    public override void PerformActivity()
    {
        DisplayStartingMessage();

        Random rnd = new Random();
        Console.WriteLine();
        Console.WriteLine(_prompts[rnd.Next(_prompts.Length)]);
        Console.WriteLine("Press Enter when you have something in mind.");
        Console.ReadLine();

        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        int questionIndex;

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            questionIndex = rnd.Next(_questions.Length);
            Console.WriteLine();
            Console.WriteLine(_questions[questionIndex]);
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}
