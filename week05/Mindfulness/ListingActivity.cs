using System;
using System.Threading;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void PerformActivity()
    {
        DisplayStartingMessage();
        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        Console.WriteLine("You may begin listing items in:");
        ShowSpinner(5);

        List<string> items = new List<string>();
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Item: ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }

        Console.WriteLine($"You listed {items.Count} items.");
        DisplayEndingMessage();
    }
}
