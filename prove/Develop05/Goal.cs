using System.Collections.Generic;

public abstract class Goal
{
    public abstract void Display();
    public virtual void GoalCalculate() { }
    public static List<Goal> GoalsList { get; } = new List<Goal>();

    public static void Create(Goal goal)
    {
        GoalsList.Add(goal);
    }

    public static void DisplayAllGoals()
    {
        foreach (var goal in GoalsList)
        {
            goal.Display();
        }
    }

    public abstract int GetScore();
}
