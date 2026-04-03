using System;
using System.Threading;

class ReflectingActivity : Activity
{
    public ReflectingActivity()
    {
        _activityName = "Reflecting Activity";
        _description = "Reflect on positive moments in your life.";
        _duration = 10; // total seconds
    }

    public void DoReflecting()
    {
        StartActivity();
        Console.WriteLine("Reflect silently...");
        Thread.Sleep(_duration * 1000);
        EndActivity();
    }
}