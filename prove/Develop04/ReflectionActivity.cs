using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : MindfulnessActivity
{
    private static readonly string[] Prompts = {
      "Think of a time when you stood up for someone else.",
      "Think of a time when you did something really difficult.",
      "Think of a time when you helped someone in need.",
      "Think of a time when you did something truly selfless."
  };

    public ReflectionActivity(int duration)
    {
        Name = "Reflection";
        Description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        Duration = duration;
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        string prompt = Prompts[random.Next(Prompts.Length)];
        Console.WriteLine(prompt);
        Thread.Sleep(2000); // Pause for 2 seconds

        for (int i = 0; i < Duration; i++)
        {
            Console.WriteLine("Reflect on your experience...");
            Thread.Sleep(2000); // Pause for 2 seconds
        }
    }
}