using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()} {_goals[i].GetDetailsString()}");
        }
    }

    public void RecordEvent(int index)
    {
        int points = _goals[index].RecordEvent();
        _score += points;

        Console.WriteLine($"You earned {points} points!");
        Console.WriteLine($"Total Score: {_score}");

        // EXTRA: Motivation
        Console.WriteLine("🔥 Keep going! You're making progress!");
    }

    public void ShowScore()
    {
        Console.WriteLine($"Your Score: {_score}");
        Console.WriteLine($"Level: {_score / 1000}");
    }

    public void Save(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetSaveString());
            }
        }
    }

    public void Load(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        _goals.Clear();

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            switch (parts[0])
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;

                case "EternalGoal":
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;

                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(
                        parts[1], parts[2],
                        int.Parse(parts[3]),
                        int.Parse(parts[5]),
                        int.Parse(parts[6])));
                    break;

                case "BadHabitGoal":
                    _goals.Add(new BadHabitGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;
            }
        }
    }
}