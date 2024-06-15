using System;
using System.Threading;

public class _BreathingActivity : _Activity
{
    public _BreathingActivity(int duration) : base(duration) { }

    public override void _Start()
    {
        _DisplayStartingMessage("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        DateTime endTime = DateTime.Now.AddSeconds(_Duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            _CountDown();
            if (DateTime.Now >= endTime)
                break;

            Console.WriteLine("Breathe out...");
            _CountDown();
        }

        base._DisplayEndingMessage("Breathing Activity");
    }

    private void _CountDown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write($" {i} ");
            Thread.Sleep(1000); // Pause for 1 second
        }
        Console.WriteLine();
    }
}
