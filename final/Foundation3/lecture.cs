public class Lecture : Event
{
    private string _speaker;
    private int _quantity;
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int quantity) : base (title, description, date, time, address)
    {
        _speaker = speaker;
        _quantity = quantity;
    }
    public override string getFullDetails()
    {
        return base.getFullDetails() + $"Speaker: {_speaker}, Quantity: {_quantity}";
    }
    public override string getShortDetails()
    {
        return $"Event Type: Lecture\nTitle: {_title}\nDate: {_date}";
    }

}