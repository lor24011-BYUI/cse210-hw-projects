using System;
using System.Collections.Generic;
public class ListingActivity : BaseActivity
{
    private List<ListingPrompts> _prompts;

    public ListingActivity(string name, string description)
        : base(name, description)
    {
        SetPrompts();
    }

    private void SetPrompts()
    {
        _prompts = new List<ListingPrompts>
        {
            new ListingPrompts("Who are people that you appreciate?"),
            new ListingPrompts("What are personal strengths of yours?"),
            new ListingPrompts("Who are people that you have helped this week?"),
            new ListingPrompts("When have you felt inspiration this month?"),
            new ListingPrompts("Who are some of your personal heroes?")
        };
    }
    public void RunActivity()
    {
        StartActivity();

        string prompt = GetPromptString(_prompts);
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($" --- {prompt} ---\n");

        RunCountDownMessage("Start", 5);
        Console.WriteLine();

        // Start timer
        StartTime();

        // Entry count
        int entryCount = 0;

        while (!HasTimerExpired())
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            entryCount++;
        }

        // End
        Console.WriteLine($"\nYou listed {entryCount} Entries!");
    }
    
}