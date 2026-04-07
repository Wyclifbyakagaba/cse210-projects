using System;

public class Behavior : Activity
{
    public void DoSomething()
    {
        StartActivity();
        PauseWithAnimation(3);
        EndActivity();
    }
}