using System;
using System.Runtime.CompilerServices;

// Inherit
public class BreathingActivity : BaseActivity
{
    // Inherit attributes :base

    // Methods
    public BreathingActivity(string name, string description)
        :base(name, description)
    {
        // Call BaseActivity, ObtainDuration
    }

    public void RunActivity()
    {
        StartActivity();

        StartTime();

        while (!HasTimerExpired())
        {
            Console.WriteLine();
            RunCountDownMessage("Breath In", 4);
            Console.WriteLine();
            RunCountDownMessage("Breath Out", 6);
            Console.WriteLine();
        }

        DisplayEnding();
    }
}