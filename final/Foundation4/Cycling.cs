public class Cycling : Activity
{
    private string _name;
    private double _speed;
    public Cycling(string date, double length, string name, double speed) : base(date, length, name)
    {
        _speed = speed;
    }
    public override double getDistance()
    {
        return (_speed * _length) / 60;
    }
    public override double getSpeed()
    {
        return _speed;
    }
    public override double getPace()
    {
        return 60 / _speed;
    }
    public override string getName()
    {
        return _name = "Cycling";
    }
}
