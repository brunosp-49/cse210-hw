using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


// I'v chosen the second idea for creative and exceeding requirements: Have your program work with a library of scriptures rather than a single one. Choose scriptures at random to present to the user.

class Program
{
    static void Main(string[] args)
    {


        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 5);

        Scripture scripture;

        switch (number)
        {
            case 1:
                scripture = new("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
                break;
            case 2:
                scripture = new("Philippians 4:13", "I can do all things through him who strengthens me.");
                break;
            case 3:
                scripture = new("Psalm 23:1", "The Lord is my shepherd; I shall not want.");
                break;
            default:
                scripture = new("Proverbs 3:5-6", "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");
                break;
        }

        scripture.Display();

        while (!scripture.AllWordsHidden())
        {
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(1);
            scripture.Display();
        }

        Console.WriteLine("You've hidden all the words in the scripture. Congratulations!");
    }
}
