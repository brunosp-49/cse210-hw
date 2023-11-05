using System;
using System.Collections.Generic;
using System.Threading;

public abstract class MindfulnessActivity
{
    public string Name { get; protected set; }
    public string Description { get; protected set; }
    public int Duration { get; protected set; }

    public void StartActivity()
    {
        List<string> animationStrings = new List<string>
   {
       "|",
       "/",
       "-",
       "\\",
       "|",
       "/",
       "-",
       "\\"
   };

        int i = 0;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        Console.WriteLine($"Starting {Name} activity...");
        Console.WriteLine(Description);
        Console.WriteLine($"Please prepare to begin. We will start in a few seconds...");
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
        PerformActivity();
        Console.WriteLine($"Great job! You have completed the {Name} activity. It lasted for {Duration} seconds.");
        Console.Write("\n");

    }

    protected abstract void PerformActivity();
}