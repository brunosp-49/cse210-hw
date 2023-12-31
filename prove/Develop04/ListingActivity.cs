using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : MindfulnessActivity
{
   private static readonly string[] _prompts = {
     "Who are people that you appreciate?",
     "What are personal strengths of yours?",
     "Who are people that you have helped this week?",
     "When have you felt the Holy Ghost this month?",
     "Who are some of your personal heroes?"
 };

   public ListingActivity(int duration)
   {
       _name = "Listing";
       _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
       _duration = duration;
   }

   protected override void PerformActivity()
   {
       Random random = new Random();
       string prompt = _prompts[random.Next(_prompts.Length)];
       Console.WriteLine(prompt);
       Thread.Sleep(2000); // Pause for 2 seconds

       List<string> _items = new List<string>();
       for (int i = 0; i < Duration; i++)
       {
           Console.WriteLine("List an item...");
           string item = Console.ReadLine();
           _items.Add(item);
           Thread.Sleep(2000); // Pause for 2 seconds
       }

       Console.WriteLine($"You listed {_items.Count} items.");
   }
}
