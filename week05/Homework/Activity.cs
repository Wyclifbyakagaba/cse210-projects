using System;
using System.Threading;

class Activity  // <-- Add this line at the very top
{
    // Protected member variables (shared with derived classes)
    protected string _activityName;
    protected string _description;
    protected int _duration;

    // Methods must be inside this class
    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_activityName}...");
        Console.WriteLine(_description);
        PauseWithAnimation(3); // small pause before starting
    }

    public void EndActivity()
    {
        Console.WriteLine($"You have completed {_activityName}.");
        PauseWithAnimation(3); // small pause at end
    }

    protected void PauseWithAnimation(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
} // <-- close Activity class here