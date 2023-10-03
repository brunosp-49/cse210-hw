using System;
using System.Collections.Generic;
using System.IO;

// I added to option delete, it deletes the file and clean the memory just passing the file name.

class JournalEntry
{
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public JournalEntry(DateTime date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    public override string ToString()
    {
        return $"Date: {Date:dd/MM/yyyy} - Prompt: {Prompt}\n{Response}\n";
    }
}

class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();

    public void AddEntry()
    {

        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 4);
        string choosed = prompts[number];
        Console.WriteLine(choosed);


        string response = Console.ReadLine();
        entries.Add(new JournalEntry(DateTime.Now, choosed, response));
        Console.WriteLine("Entry added successfully!");
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"Date: {entry.Date:dd/MM/yyyy}");
                writer.WriteLine($"Prompt: {entry.Prompt}");
                writer.WriteLine($"{entry.Response}\n");
            }
        }
        Console.WriteLine("Journal saved to file successfully!");
    }

    public void DeleteFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            File.Delete(fileName);
            Console.WriteLine($"File '{fileName}' deleted successfully!");
            entries.Clear();
        }
        else
        {
            Console.WriteLine($"File '{fileName}' does not exist.");
        }
    }

    public void LoadFromFile(string fileName)
    {
        entries.Clear();
        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    DateTime date = DateTime.ParseExact(reader.ReadLine().Substring(6), "dd/MM/yyyy", null);
                    string prompt = reader.ReadLine().Substring(8);
                    string response = reader.ReadLine();
                    entries.Add(new JournalEntry(date, prompt, response));
                    reader.ReadLine();
                }
            }
            Console.WriteLine("Journal loaded from file successfully!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error loading journal from file: " + e.Message);
        }
    }
}

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
