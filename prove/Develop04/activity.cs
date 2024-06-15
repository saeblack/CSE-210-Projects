using System;

public class _Activity
{
    public int _Duration { get; }

    public _Activity(int duration)
    {
        _Duration = duration;
    }

    public virtual void _Start()
    {
        Console.WriteLine($"Starting {GetType().Name}...");
        DateTime startTime = DateTime.Now;

        // Calculate end time based on start time and duration
        DateTime endTime = startTime.AddSeconds(_Duration);

        while (DateTime.Now < endTime)
        {
            // Activity is still running within the specified duration
            // You can place the specific activity logic here
        }

        // Display ending message when the duration is up
        _DisplayEndingMessage(GetType().Name);
    }

    protected void _DisplayStartingMessage(string activityName, string description)
    {
        Console.WriteLine($"Starting {activityName}...");
        Console.WriteLine(description);
        Console.WriteLine($"Duration: {_Duration} seconds");
    }

    protected void _DisplayEndingMessage(string activityName)
    {
        Console.WriteLine($"Congratulations! You have completed the {activityName}.");
        Console.WriteLine($"Total duration: {_Duration} seconds");
        Console.WriteLine("Well done!\n");
    }
}


