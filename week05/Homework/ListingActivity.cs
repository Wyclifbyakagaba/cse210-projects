using System;
using System.Threading;

class ListingActivity : Activity
{
    public ListingActivity()
    {
        _activityName = "Listing Activity";
        _description = "List as many positive things as you can.";
        _duration = 10; // total seconds
    }

    public void DoListing()
    {
        StartActivity();
        Console.WriteLine("Write your items (pretend to type)...");
        Thread.Sleep(_duration * 1000);
        EndActivity();
    }
}