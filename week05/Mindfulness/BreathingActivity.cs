using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void PerformActivity()
    {
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            Countdown(4);
            Console.WriteLine();
            Console.Write("Breathe out... ");
            Countdown(4);
            Console.WriteLine();
        }
    }
}