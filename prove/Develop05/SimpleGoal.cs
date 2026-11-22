using System;

public class SimpleGoal : BaseGoal
{   
    // Report if goal is complete
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    // Record event
    public override int RecordEvent()
    {   
        _isComplete = true;
        return _points;
    }

    // Set IsComplete To 
    public override bool IsComplete() 
    {
        return _isComplete;
    }

    // GetListGoals calles the goals and adds a checkbox
    public override string GetListGoals()
    {
        string completed;

        if (IsComplete() == true)
        {
            completed = "X";
        }
        else
        {
            completed = " ";
        }
        return $"[{completed}] {base.GetListGoals()}";
    }

    // Formate Goal to be saved
    public override string GetFileString()
    {
        return $"SimpleGoal,{_name},{_description},{_points},{_isComplete}";
    }
}