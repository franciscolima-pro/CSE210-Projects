public class Reception : Event
{
    string _rsvpEmail;
    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }
    public override string getFullDetails()
    {
        return base.getFullDetails() + $"Email: {_rsvpEmail}";
    }
    public override string getShortDetails()
    {
        return $"Event Type: Reception\nTitle: {_title}\nDate: {_date}";
    }
}