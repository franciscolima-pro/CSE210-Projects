using System.ComponentModel;

public class Event
{
    protected string _title;
    private string _description;
    protected string _date;
    private string _time;
    private Address _address;
    public Event (string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string getStandardDetails()
    {
        return $"Title: {_title}, Description: {_description}, Date: {_date}, Address: {_address}";
    }
    public virtual string getFullDetails()
    {
        return getStandardDetails();
    }
    public virtual string getShortDetails()
    {
        return $"Event Type: General Event: Title: {_title}, Date: {_date}";
    }
}