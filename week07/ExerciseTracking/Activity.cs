using System;

public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual double GetCalories()
    {
        return _minutes * 5;
    }

    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_minutes} min): " +
                $"Distance {GetDistance():F1} km/h," +
                $"Speed {GetSpeed():F1} km/h," +
                $"Pace {GetPace():F2} min per km," +
                $"Calories {GetCalories():F0}";
    }
}