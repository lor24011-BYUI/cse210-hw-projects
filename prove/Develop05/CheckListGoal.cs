using System;
using System.ComponentModel;
using System.Runtime;


public class CheckListGoal : BaseGoal
{
    // Check List Attributes
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus, int amountCompleted = 0)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    // RecordEvent increment each time and checks for bonus
    public override int RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted >= _target)
        {
            return _points + _bonus;
        }
        else
        {
            return _points;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    // GetListGoals to display checklist
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

        return $"[{completed}] {base.GetListGoals()} - Completed: {_amountCompleted} / {_target}";
    }

    // Format for save
    public override string GetFileString()
    {
        return $"CheckListGoal,{_name},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}