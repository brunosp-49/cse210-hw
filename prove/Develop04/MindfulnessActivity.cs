using System;
using System.Collections.Generic;
using System.Threading;

public abstract class MindfulnessActivity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public string Name { get => _name; protected set => _name = value; }
    public string Description { get => _description; protected set => _description = value; }
    public int Duration { get => _duration; protected set => _duration = value; }

    public void StartActivity()
    {
        List<string> _animationStrings = new List<string>
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

        int _i = 0;

        DateTime _startTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds(5);

        Console.WriteLine($"Starting {Name} activity...");
        Console.WriteLine(Description);
        Console.WriteLine($"Please prepare to begin. We will start in a few seconds...");
        while (DateTime.Now < _endTime)
        {
            string _s = _animationStrings[_i];
            Console.Write(_s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            _i++;

            if (_i >= _animationStrings.Count)
            {
                _i = 0;
            }
        }
        PerformActivity();
        Console.WriteLine($"Great job! You have completed the {Name} activity. It lasted for {Duration} seconds.");
        Console.Write("\n");

    }

    protected abstract void PerformActivity();
}
