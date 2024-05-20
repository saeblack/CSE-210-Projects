using System;

public class Entries
{
    public class Entry
    {
        public string Prompt { get; set; }
        public string Input { get; set; }
        public string LoggedDate { get; set; } // Change type to string
    }

    public Entry NewEntrie()
    {
        Prompt prompt = new Prompt();

        string question = prompt.GetRanQuestions();
        Console.WriteLine(question);
        string input = Console.ReadLine();

        DateTime inputDate = DateTime.Now;
        string inputDateString = inputDate.ToString("yyyy-MM-dd HH:mm:ss"); // Convert DateTime to string

        Console.WriteLine("You inputted: " + input);
        Console.WriteLine("Logged Date: " + inputDateString); // Output the string representation of the date

        return new Entry
        {
            Prompt = question,
            Input = input,
            LoggedDate = inputDateString // Assign string representation of the date
        };
    }
}


