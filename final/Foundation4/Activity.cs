public class Activity 
{
    private string _name;
    private string _date;
    protected double _length;
    public Activity (string date, double length, string name)
    {
        _date = date;
        _length = length;
        _name = name;
    }

    public virtual double getDistance()
    {
        return 0;
    }
    public virtual double getSpeed()
    {
        return 0;
    }
    public virtual double getPace()
    {
        return 0;
    }
    public virtual string getName()
    {
        return _name;
    }
    public virtual string getSumary()
    {
        return $"{_date} {getName()} {_length}" +
        $"Distance: {getDistance():F2} KM, " +
        $"Speed: {getSpeed():F2} Kph, " +
        $"Pace: {getPace():F2} min per Km";
    }
}