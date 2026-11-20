using System;

public abstract class BaseGoal
{   
    // Attributes
    protected string _name;
    protected string _description;
    protected int _points;

    public BaseGoal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }


    // Force child programs to record and check the goal and return string
    public abstract int RecordEvent();

    // Force Goal to report if completed
    public abstract bool IsComplete();

    // Return Goal Details
    public virtual string GetListGoals()
    {
        return $"Goal: {_name} Description: {description}"
    }

    // Force child programs to save file
    public abstract string GetFileString

}