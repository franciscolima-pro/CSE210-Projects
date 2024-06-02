public class OutdoorGathering : Event
{
    private string _wheatherForecast;
    public OutdoorGathering(string title, string description, string date, string time, Address address, string wheatherForecast) : base (title, description, date, time, address)
    {
        _wheatherForecast = wheatherForecast;
    }
    public override string getFullDetails()
    {
        return base.getFullDetails() + $"Wheather Forecast: {_wheatherForecast}";
    }
    public override string getShortDetails()
    {
        return $"Event Type: Outdoor Gathering\nTitle: {_title}\nDate: {_date}";
    }
}