using System;

public class Cycling : Activity
{
    private double _speedKmH;

    public Cycling(string date, int minutes, double speedKmH)
        : base(date, minutes)
    {
        _speedKmH = speedKmH;
    }

    public override double GetDistance()
    {
        return (_speedKmH * GetMinutes()) / 60;
    }

    public override double GetSpeed()
    {
        return _speedKmH;
    }

    public override double GetPace()
    {
        return 60 / _speedKmH;
    }
}