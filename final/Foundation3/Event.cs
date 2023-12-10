using System;

class Event
{
    protected string eventTitle;
    protected string eventDescription;
    protected DateTime eventDate;
    protected string eventTime;
    protected Address eventAddress;

    public Event(string title, string description, DateTime date, string time, Address address)
    {
        eventTitle = title;
        eventDescription = description;
        eventDate = date;
        eventTime = time;
        eventAddress = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Title: {eventTitle}\nDescription: {eventDescription}\nDate: {eventDate.ToShortDateString()}\nTime: {eventTime}\nAddress: {eventAddress}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Type: Base Event\nTitle: {eventTitle}\nDate: {eventDate.ToShortDateString()}";
    }
}