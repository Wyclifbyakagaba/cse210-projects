using System;

public class BadHabitGoal : Goal
{
    public BadHabitGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        return -_points; // subtract points
    }

    public override string GetStatus()
    {
        return "[!]";
    }

    public override bool IsComplete() => false;

    public override string GetSaveString()
    {
        return $"BadHabitGoal|{base.GetSaveString()}";
    }
}