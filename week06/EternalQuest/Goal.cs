using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    //Builder that receives the main information from the goal
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    //Return the points
    public int GetPoints()
    {
        return _points;
    }

    //These methods are defined for each meta type
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    //Displays basic meta information
    public virtual string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName}: {_description}";
    }
}