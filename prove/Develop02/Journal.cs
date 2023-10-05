using System;
using System.Collections.Generic;
using System.IO;

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