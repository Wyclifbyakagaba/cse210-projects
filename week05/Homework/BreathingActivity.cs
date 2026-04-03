// BreathingActivity.cs
using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _activityName = "Breathing Activity";
        _description = "Focus on your breathing.";
        _duration = 10;
    }

    public void startBreathing()
    {
        StartActivity();
        for (int i = 0; i < _duration / 5; i++)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(2500);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(2500);
        }
        EndActivity(); // inherited from Activity
    }
}