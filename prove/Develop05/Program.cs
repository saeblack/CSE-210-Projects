using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Load existing goals from file
        AbstractScore.LoadGoals("goals.txt");

        // Display existing goals
        Goal.DisplayAllGoals();
        AbstractScore.DisplayScore();

        // User interaction loop
        while (true)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Save goals and exit");
            Console.Write("Enter your choice (1-3): ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateNewGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    AbstractScore.SaveGoals("goals.txt");
                    Console.WriteLine("Goals saved successfully. Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please choose 1, 2, or 3.");
                    break;
            }

            // Display updated goals and score after each operation
            Goal.DisplayAllGoals();
            AbstractScore.DisplayScore();
        }
    }

    private static void CreateNewGoal()
    {
        Console.WriteLine("\nEnter a goal type (Simple, Infinite, Checklist): ");
        string goalType = Console.ReadLine();

        Console.WriteLine("Enter the goal description: ");
        string goalDescription = Console.ReadLine();

        switch (goalType.ToLower())
        {
            case "simple":
                Goal.Create(new SimpleGoal(goalDescription, 0));
                break;
            case "infinite":
                Goal.Create(new InfiniteGoal(goalDescription, 0));
                break;
            case "checklist":
                Goal.Create(new ChecklistGoal(new List<string> { goalDescription }, 0, 0));
                break;
            default:
                Console.WriteLine("Unknown goal type.");
                break;
        }

        Console.WriteLine("New goal created successfully.");
    }

    private static void RecordEvent()
    {
        Console.WriteLine("\nSelect a goal to record an event:");
        for (int i = 0; i < Goal.GoalsList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Goal.GoalsList[i].GetType().Name}: {Goal.GoalsList[i].ToString()}");
        }

        Console.Write("Enter the number of the goal: ");
        if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex > 0 && goalIndex <= Goal.GoalsList.Count)
        {
            Goal selectedGoal = Goal.GoalsList[goalIndex - 1];
            selectedGoal.GoalCalculate();
            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }
}
