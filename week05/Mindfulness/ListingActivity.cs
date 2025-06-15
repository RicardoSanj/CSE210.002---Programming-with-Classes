
using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private string[] _prompts = {
        "List things you are grateful for:",
        "List people who have helped you:",
        "List moments that made you smile recently:"
    };

    public ListingActivity()
    {
        SetName("Listing");
        SetDescription("This activity helps you reflect on good things in your life by listing them.");
    }

    public override void PerformActivity()
    {
        DisplayStartingMessage();

        Random rnd = new Random();
        string prompt = _prompts[rnd.Next(_prompts.Length)];
        Console.WriteLine();
        Console.WriteLine(prompt);
        Console.WriteLine("You may begin listing items. Press Enter after each item.");
        Console.WriteLine("You have " + GetDuration() + " seconds...");
        ShowCountdown(5);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable || Console.In.Peek() != -1)
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
