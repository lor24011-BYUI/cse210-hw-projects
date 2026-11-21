using System;
// For Lists
using System.Collections.Generic;
// For StreamWriter
using System.IO;

public class ListGoals
{
    private List<BaseGoal> _goals = new List<BaseGoal>();
    private int _score;

    // Constructor 0 score empty goal
    public ListGoals()
    {
        _score = 0;
        _goals = new List<BaseGoal>();
    }
    
    // Return Score
    public int GetScore()
    {
        return _score;
    }

    // add goals
    public void AddGoal(BaseGoal goal)
    {
        _goals.Add(goal);
    }

    //Display goal
    public void DisplayGoals()
    {
        Console.WriteLine("The Goals Are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetListGoals()}\n");
        }
    }

    // Record Goal
    public void RecordEvent(int goalIndex)
    {
        // Adjust input to start at 1
        int listIndex = goalIndex -1;

        
        if (listIndex >= 0 && listIndex < _goals.Count)
        {
            int pointsEarned = _goals[listIndex].RecordEvent();
            _score += pointsEarned;

            Console.WriteLine($"Congradulations! you earned {pointsEarned} points.\n");
            Console.WriteLine($"You now have {_score} points\n.");
        }
        else
        {
            Console.WriteLine("Invalid Selection");
        }
    }

    //Save Goal
    public void SaveGoals(string filename) 
    { 
        using (StreamWriter writer = new StreamWriter(filename)) 
        { 
            writer.WriteLine(_score); 
            foreach (BaseGoal goal in _goals) 
            { 
                writer.WriteLine(goal.GetFileString()); 
            } 
        } 
        Console.WriteLine($"Goals successfully saved to {filename}!");
    }

    // Load Goal
    public void LoadGoals(string filename)
    {   
        // Check for filename and report if not found
        if (!File.Exists(filename))
        {
            Console.WriteLine("File Not Found\n");
            return;
        }

        // Clear list to prevent merging lists
        _goals.Clear();
        bool isFirstLine = true;

        foreach (string line in File.ReadAllLines(filename))
        {
            if (isFirstLine)
            {
                _score = int.Parse(line);
                isFirstLine = false;
            }
            else
            {
                string[] parts = line.Split(",");
                string goalType = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                // Goal Types
                if (goalType == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(parts[4]);
                    _goals.Add(new SimpleGoal(name, description, points, isComplete));
                }
                else if (goalType == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(name, description, points));
                }
                else if (goalType == "CheckListGoal")
                {
                    int target = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    int amountCompleted = int.Parse(parts[6]);
                    _goals.Add(new CheckListGoal(name, description, points, target, bonus, amountCompleted));
                }
            }
        }
        Console.WriteLine($"Goals Loaded from {filename}");
    }
}