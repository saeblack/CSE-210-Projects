using System;
using System.IO;

public class AbstractScore
{
    public static void DisplayScore()
    {
        int totalScore = 0;
        foreach (var goal in Goal.GoalsList)
        {
            totalScore += goal.GetScore();
        }
        Console.WriteLine($"Total Score: {totalScore}");
    }

    public static void SaveGoals(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var goal in Goal.GoalsList)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal}");
            }
        }
    }

    public static void LoadGoals(string fileName)
    {
        Goal.GoalsList.Clear();
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split(',');
                if (parts.Length < 3)
                {
                    Console.WriteLine($"Invalid data format: {line}");
                    continue;
                }

                string goalType = parts[0];
                string goalDescription = parts[1];
                int score = int.Parse(parts[2]);

                switch (goalType)
                {
                    case "InfiniteGoal":
                        Goal.GoalsList.Add(new InfiniteGoal(goalDescription, score));
                        break;
                    case "SimpleGoal":
                        Goal.GoalsList.Add(new SimpleGoal(goalDescription, score));
                        break;
                    case "ChecklistGoal":
                        Goal.GoalsList.Add(new ChecklistGoal(new List<string> { goalDescription }, score, 0));
                        break;
                    default:
                        Console.WriteLine($"Unknown goal type: {goalType}");
                        break;
                }
            }
        }
    }
}
