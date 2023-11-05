using System;
using System.Collections.Generic;
using System.Threading;

// I added two Creativity and Exceeding Requirements:
// 1 - Keeping a log of how many times activities were performed(It shows when you finish the program)
// 2 - Make sure no random prompts/questions are selected until they have all been used at least once in that session.

public class Program
{
    private static Dictionary<string, int> _activityCounts = new Dictionary<string, int>();

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();
            if (choice == "4") break;

            Console.WriteLine("How long, in seconds, would you like for your session?");
            int duration = int.Parse(Console.ReadLine());

            MindfulnessActivity activity = null;
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Welcome to the Breathing Activity.");
                    activity = new BreathingActivity(duration);
                    break;
                case "2":
                    Console.WriteLine("Welcome to the Reflection Activity.");
                    activity = new ReflectionActivity(duration);
                    break;
                case "3":
                    Console.WriteLine("Welcome to the Listing Activity.");
                    activity = new ListingActivity(duration);
                    break;
            }

            if (activity != null)
            {
                activity.StartActivity();
                if (_activityCounts.ContainsKey(activity.Name))
                {
                    _activityCounts[activity.Name]++;
                }
                else
                {
                    _activityCounts[activity.Name] = 1;
                }
            }
        }

        foreach (var pair in _activityCounts)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
