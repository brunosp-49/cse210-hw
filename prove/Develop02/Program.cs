using System;
using System.Collections.Generic;
using System.IO;

// I added to option delete, it deletes the file and clean the memory just passing the file name.

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Please Select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Delete");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    myJournal.AddEntry();
                    break;
                case "2":
                    Console.WriteLine("Journal Entries:");
                    myJournal.DisplayEntries();
                    break;
                case "3":
                    Console.Write("Enter a filename to save the journal: ");
                    string saveFileName = Console.ReadLine();
                    myJournal.SaveToFile(saveFileName);
                    break;
                case "4":
                    Console.Write("Enter a filename to load the journal: ");
                    string loadFileName = Console.ReadLine();
                    myJournal.LoadFromFile(loadFileName);
                    break;
                case "5":
                    Console.Write("Enter a filename to delete: ");
                    string deleteFileName = Console.ReadLine();
                    myJournal.DeleteFile(deleteFileName);
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
