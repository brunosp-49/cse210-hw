using System;

class Program
{
    static void Main(string[] args)
    {
        Address eventAddress1 = new Address { Street = "123 Main St", City = "City", State = "State", ZipCode = "12345" };
        Address eventAddress2 = new Address { Street = "456 Park Ave", City = "Town", State = "State", ZipCode = "67890" };
        Address eventAddress3 = new Address { Street = "789 Garden Ln", City = "Village", State = "State", ZipCode = "13579" };

        Event lectureEvent = new Lecture("Tech Talk", "Latest in Technology", new DateTime(2023, 12, 15), "10:00 AM", eventAddress1, "John Doe", 50);
        Event receptionEvent = new Reception("Networking Mixer", "Connect and Network", new DateTime(2023, 12, 20), "7:00 PM", eventAddress2, "rsvp@example.com");
        Event outdoorEvent = new OutdoorGathering("Summer Picnic", "Enjoy Outdoors", new DateTime(2023, 12, 25), "12:00 PM", eventAddress3, "Sunny");

        Console.WriteLine("Standard Details:");
        Console.WriteLine("Lecture Event:");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine("\nReception Event:");
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine("\nOutdoor Gathering Event:");
        Console.WriteLine(outdoorEvent.GetStandardDetails());

        Console.WriteLine("\nFull Details:");
        Console.WriteLine("Lecture Event:");
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine("\nReception Event:");
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine("\nOutdoor Gathering Event:");
        Console.WriteLine(outdoorEvent.GetFullDetails());

        Console.WriteLine("\nShort Description:");
        Console.WriteLine("Lecture Event:");
        Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine("\nReception Event:");
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine("\nOutdoor Gathering Event:");
        Console.WriteLine(outdoorEvent.GetShortDescription());

        Console.ReadLine();
    }
}
