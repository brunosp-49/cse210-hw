using System;
using System.Collections.Generic;
using System.Threading;

public class Program
{
    private static Dictionary<string, int> activityCounts = new Dictionary<string, int>();

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
                if (activityCounts.ContainsKey(activity.Name))
                {
                    activityCounts[activity.Name]++;
                }
                else
                {
                    activityCounts[activity.Name] = 1;
                }
            }
        }

        foreach (var pair in activityCounts)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
