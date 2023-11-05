using System;
using System.Collections.Generic;
using System.Threading;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(int duration)
    {
        _name = "Breathing";
        _description = "This activity will help you relax by guiding you through slow, deep breathing. Clear your mind and focus on your breathing.";
        _duration = duration;
    }

    protected override void PerformActivity()
    {
        int times = Duration / 8;
        if (Duration < 8)
        {
            times = 1;
        }
        for (int i = times; i > 0; i--)
        {
            for (int s = 3; s > 0; s--)
            {
                Console.Write("\rBreathe in...{0}", s);
                Thread.Sleep(1000); // Pause for 1 second  
            }
            Console.Write("\n");
            for (int f = 4; f > 0; f--)
            {
                Console.Write("\rNow breathe out...{0}", f - 1);
                Thread.Sleep(1000); // Pause for 1 second 
            }
            Console.Write("\n");
            Console.Write("\n");
        }
    }
}