
using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetName("Breathing");
        SetDescription("This activity will help you relax by guiding you through slow breathing.");
    }

    public override void PerformActivity()
    {
        DisplayStartingMessage();
        for (int i = 0; i < GetDuration(); i += 8)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine("Breathe out...");
            ShowCountdown(4);
        }
        DisplayEndingMessage();
    }
}
