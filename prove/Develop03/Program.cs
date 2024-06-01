using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            Dictionary<string, string> scriptures = store.GetScriptures();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Scripture Memorization Game");
                Console.WriteLine("Select a scripture to practice:");

                int index = 1;
                foreach (var key in scriptures.Keys)
                {
                    Console.WriteLine($"{index}. {key}");
                    index++;
                }
                Console.WriteLine($"{index}. Exit");

                if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= scriptures.Count)
                {
                    string selectedScripture = new List<string>(scriptures.Keys)[choice - 1];
                    string verse = store.GetVerse(selectedScripture);

                    bool keepQuizzing = true;
                    while (keepQuizzing)
                    {
                        Display.ShowVerse(selectedScripture, verse);

                        Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
                        string input = Console.ReadLine();

                        switch (input.ToLower())
                        {
                            case "quit":
                                keepQuizzing = false;
                                break;

                            case "":
                                string modifiedVerse = Quiz.GenerateQuiz(verse);
                                verse = modifiedVerse;

                                if (verse.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).All(word => word == "____"))
                                {
                                    Console.Clear();
                                    Console.WriteLine("All words have been hidden. Well done!");
                                    keepQuizzing = false;
                                }
                                break;

                            default:
                                Console.WriteLine("Invalid input. Please press Enter to continue or type 'quit' to exit.");
                                break;
                        }
                    }
                }
                else if (choice == index)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }
    }
}
