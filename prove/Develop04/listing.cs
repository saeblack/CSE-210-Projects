using System;
using System.Collections.Generic;
using System.Threading;

public class _ListingActivity : _Activity
{
    private string[] _Prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public _ListingActivity(int duration) : base(duration) { }

    public override void _Start()
    {
        _DisplayStartingMessage("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        int remainingDuration = _Duration;
        List<string> itemList = new List<string>();

        // Select a random prompt from the prompts array
        Random random = new Random();
        string randomPrompt = _Prompts[random.Next(_Prompts.Length)];
        Console.WriteLine(randomPrompt);

        foreach (string prompt in _Prompts)
        {
            // Give the user a countdown to begin thinking about the prompt
            Console.WriteLine($"Time remaining: {remainingDuration} seconds");
            Thread.Sleep(1000); // Pause for 1 second
            remainingDuration--;

            // Prompt the user to list items
            Console.WriteLine("Press Enter after each item, or type 'done' to finish:");
            string input;
            DateTime endTime = DateTime.Now.AddSeconds(_Duration);
            do
            {
                input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    itemList.Add(input);
                    Console.WriteLine($"Time remaining: {Math.Max(0, (int)((endTime - DateTime.Now).TotalSeconds))} seconds");
                }
            } while (!string.IsNullOrWhiteSpace(input) && DateTime.Now < endTime);

            // If time runs out, exit the loop
            if (DateTime.Now >= endTime)
                break;
        }

        // Display the items listed
        Console.WriteLine("\nYou listed the following items:");
        foreach (string item in itemList)
        {
            Console.WriteLine(item);
        }

        _DisplayEndingMessage("Listing Activity");
    }
}
