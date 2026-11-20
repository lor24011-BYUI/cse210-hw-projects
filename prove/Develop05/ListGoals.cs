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
        
        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines);

        for (int i = 1; if < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(":");
            string goalType = parts;
            string details = parts[4].Split(",");
            if (goalType == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(details, details[4], int.Parse(details[5]), bool.Parse[6]));
            }
        }
    }
}