using System;
using System.Collections.Generic;

public class ReflectionActivity : BaseActivity
{
    private List<ListingPrompts> _prompts;
    private List<ListingPrompts> _questions;

    public ReflectionActivity(string name, string description)
        :base(name,description)
    {
        SetPromptsandQuestions();
    }

    private void SetPromptsandQuestions()
    {
        // List of prompts
        _prompts = new List<ListingPrompts>
        {
            new ListingPrompts("Think of a time when you stood up for someone else."),
            new ListingPrompts("Think of a time when you did something really difficult."),
            new ListingPrompts("Think of a time when you helped someone in need."),
            new ListingPrompts("Think of a time when you did something truly selfless."),
            
        };

        // List of Questions
        _questions = new List<ListingPrompts>
        {
            new ListingPrompts("Why was this experience meaningful to you?"),
            new ListingPrompts("Have you ever done anything like this before?"),
            new ListingPrompts("How did you get started?"),
            new ListingPrompts("How did you feel when it was complete?"),
            new ListingPrompts("What made this time different than other times?"),
            new ListingPrompts("What is your favorite thing about this experience?")
        };
    }

    public void RunActivity()
    {
        StartActivity();

        // Display random prompt
        string prompt = GetPromptString(_prompts);
        Console.WriteLine("Consider the following prompt: \n");
        Console.WriteLine($" --- {prompt} ---");
        RunCountDownMessage("Please Start in: ", 5);

        // Timer
        StartTime();

        while (!HasTimerExpired())
        {
            string question = GetPromptString(_questions);
            Console.WriteLine($"> {question} ");
            DisplaySpinnerMessage("", 5);
            Console.WriteLine("");
        }
        
        //End
        DisplayEnding();
    }
}