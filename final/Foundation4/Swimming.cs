using System.Diagnostics;

public class Swimming : Activity
{
    private string _name;
    private double _numberLaps;
    private double LapLength = 50;
    public Swimming(string date, double length, string name, double numberLaps) : base(date, length, name)
    {
        _numberLaps = numberLaps;       
    }
    public override double getDistance()
    {
        return (_numberLaps * LapLength) / 1000;
    }
    public override double getSpeed()
    {
        return (getDistance() / _length) *  60;
    }
    public override double getPace()
    {
        return _length / getDistance();
    }
    public override string getName()
    {
        return _name = "Swimming";
    }
}