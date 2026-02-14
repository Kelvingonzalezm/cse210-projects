using System;

public class Running : Activity
{
    private double _distancekm;

    public Running(string date, int minutes, double distancekm)
        : base(date, minutes)
    {
        _distancekm = distancekm;
    }

    public override double GetDistance()
    {
        return _distancekm;
    }

    public override double GetSpeed()
    {
        return (_distancekm / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / _distancekm;
    }
}