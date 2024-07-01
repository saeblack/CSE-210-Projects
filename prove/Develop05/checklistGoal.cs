using System;
using System.Collections.Generic;

public class ChecklistGoal : Goal
{
    private List<string> _goals;
    private int _score;
    private int _itemCount;

    public ChecklistGoal(List<string> goals, int score, int itemCount)
    {
        _goals = goals;
        _score = score;
        _itemCount = itemCount;
    }

    public override void Display()
    {
        Console.WriteLine($"Checklist Goals: {string.Join(", ", _goals)} - Score: {_score} - Completed: {_itemCount}/{_goals.Count}");
    }

    public void Bonus()
    {
        if (_itemCount >= 10)
        {
            _score += 500; // Example bonus
        }
    }

    public override void GoalCalculate()
    {
        _score += 50; // Example increment
        _itemCount++;
        if (_itemCount >= 10)
        {
            Bonus();
        }
    }

    public override int GetScore()
    {
        return _score;
    }

    public override string ToString()
    {
        return $"Checklist Goals: {string.Join(", ", _goals)} - Score: {_score} - Completed: {_itemCount}/{_goals.Count}";
    }
}
