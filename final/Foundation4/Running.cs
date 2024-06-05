public class Running : Activity
{
    private string _name;
    private double _distance;
    public Running(string date, double length, string name, double distance) : base(date, length, name)
    {
        _distance = distance;
    }
    public override double getDistance()
    {
        return _distance;
    }
    public override double getSpeed()
    {
        return (_distance / _length) * 60;
    }
    public override double getPace()
    {
        return _length / _distance;
    }
    public override string getName()
    {
        return _name = "Running";
    }
}