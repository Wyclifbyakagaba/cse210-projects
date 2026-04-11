using System;

public class ChecklistGoal : Goal
{
    private int _target;
    private int _count;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _count = 0;
    }

    public override int RecordEvent()
    {
        _count++;
        int total = _points;

        if (_count == _target)
        {
            total += _bonus;
        }

        return total;
    }

    public override string GetStatus()
    {
        return _count >= _target ? "[X]" : "[ ]";
    }

    public override bool IsComplete() => _count >= _target;

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} -- Completed {_count}/{_target}";
    }

    public override string GetSaveString()
    {
        return $"ChecklistGoal|{base.GetSaveString()}|{_count}|{_target}|{_bonus}";
    }
}