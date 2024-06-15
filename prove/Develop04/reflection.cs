using System;
using System.Threading;

public class _ReflectionActivity : _Activity
{
    private string[] _Prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _Questions = {
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

    private volatile bool _StopSpinner = false;

    public _ReflectionActivity(int duration) : base(duration) { }

    public override void _Start()
    {
        _DisplayStartingMessage("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        DateTime endTime = DateTime.Now.AddSeconds(_Duration);

        // Display spinner while activity is running
        Thread spinnerThread = new Thread(() => _DisplaySpinner(endTime));
        spinnerThread.Start();

        Random random = new Random();
        while (DateTime.Now < endTime)
        {
            string randomPrompt = _Prompts[random.Next(_Prompts.Length)];
            Console.WriteLine(randomPrompt);

            foreach (string question in _Questions)
            {
                Console.WriteLine(question);
                Thread.Sleep(3000); // Pause for several seconds

                if (DateTime.Now >= endTime)
                    break;
            }
        }

        // Set the flag to stop the spinner thread
        _StopSpinner = true;

        base._DisplayEndingMessage("Reflection Activity");
    }

    private void _DisplaySpinner(DateTime endTime)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int index = 0;
        while (!_StopSpinner && DateTime.Now < endTime)
        {
            Console.Write($"\r{spinner[index++ % spinner.Length]}");
            Thread.Sleep(100); // Adjust speed of spinner here
        }
    }
}



