using System;
using System.Threading;

public class Activity
{ 
    protected string _activityName;
    protected string _description;
    protected int _duration; // ✅ ADD THIS

    public void StartActivity()
    {
        Console.WriteLine($"Starting {_activityName}");
    }

    public void EndActivity()
    {
        Console.WriteLine($"Ending {_activityName}");
    }

    public void PauseWithAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}