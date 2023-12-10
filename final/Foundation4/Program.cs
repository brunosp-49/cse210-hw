using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        // Creating instances of each activity type
        activities.Add(new RunningActivity("03 Nov 2022", 30, 3.0));
        activities.Add(new CyclingActivity("03 Nov 2022", 30, 20.0));
        activities.Add(new SwimmingActivity("03 Nov 2022", 30, 10));

        // Displaying summary for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}