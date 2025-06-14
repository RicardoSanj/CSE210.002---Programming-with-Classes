using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
    )
    {
    }

    public override void PerformActivity()
    {
        DisplayStartingMessage();

        int duration = GetDuration();
        int elapsed = 0;
        int breathTime = 4; // segundos para cada inhalar/exhalar

        while (elapsed < duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(breathTime);
            elapsed += breathTime;

            if (elapsed >= duration) break;

            Console.WriteLine("Breathe out...");
            ShowCountdown(breathTime);
            elapsed += breathTime;
        }

        DisplayEndingMessage();
    }
}
