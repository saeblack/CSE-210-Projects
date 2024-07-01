using System;

public class InfiniteGoal : Goal
{
    private string _goalDescription;
    private int _score;

    public InfiniteGoal(string goal, int score)
    {
        _goalDescription = goal;
        _score = score;
    }

    public override void Display()
    {
        Console.WriteLine($"{_goalDescription} - Score: {_score}");
    }

    public override void GoalCalculate()
    {
        _score += 100; // Example increment
    }

    public override int GetScore()
    {
        return _score;
    }

    public override string ToString()
    {
        return $"{_goalDescription} - Score: {_score}";
    }
}
