using System;

class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, DateTime date, string time, Address address, string email)
        : base(title, description, date, time, address)
    {
        rsvpEmail = email;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nType: Reception\nRSVP Email: {rsvpEmail}";
    }

    public override string GetShortDescription()
    {
        return $"Type: Reception\nTitle: {base.eventTitle}\nDate: {base.eventDate.ToShortDateString()}";
    }
}