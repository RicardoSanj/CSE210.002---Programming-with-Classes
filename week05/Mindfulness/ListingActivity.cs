using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
    )
    {
    }

    public override void PerformActivity()
    {
        DisplayStartingMessage();

        Random rnd = new Random();
        string prompt = _prompts[rnd.Next(_prompts.Length)];
        Console.WriteLine();
        Console.WriteLine(prompt);
        Console.WriteLine("You have 5 seconds to think...");
        ShowCountdown(5);

        List<string> items = new List<string>();

        DateTime startTime = DateTime.Now;
        int duration = GetDuration();

        Console.WriteLine("Start listing items. Press Enter after each one:");

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            if (Console.KeyAvailable)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    items.Add(input);
                }
            }
        }

        Console.WriteLine($"You listed {items.Count} items.");

        DisplayEndingMessage();
    }
}
