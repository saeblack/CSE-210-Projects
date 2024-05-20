using System;
using System.Collections.Generic;
using System.IO;

public class SavedEntries
{
    private List<Entries.Entry> entries = new List<Entries.Entry>();

    public void AddEntry(Entries.Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Input: {entry.Input}");
            Console.WriteLine($"Logged Date: {entry.LoggedDate}");
            Console.WriteLine();
        }
    }

    public void SaveJournalToFile(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in entries)
                {
                    // Use a symbol (e.g., '|') as a separator for fields in CSV format
                    writer.WriteLine($"{entry.Prompt}|{entry.Input}|{entry.LoggedDate}");
                }
            }
            Console.WriteLine("Journal saved to file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal to file: {ex.Message}");
        }
    }

    public void LoadJournalFromFile(string filename)
    {
        try
        {
            entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split('|');
                    if (fields.Length == 3) // Ensure all fields are present
                    {
                        string prompt = fields[0];
                        string input = fields[1];
                        string loggedDate = fields[2]; // Store as string

                        entries.Add(new Entries.Entry
                        {
                            Prompt = prompt,
                            Input = input,
                            LoggedDate = loggedDate
                        });
                    }
                }
            }
            Console.WriteLine("Journal loaded from file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal from file: {ex.Message}");
        }
    }
}








