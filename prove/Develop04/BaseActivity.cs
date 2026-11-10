using System;
using System.Collections.Generic;
using System.Threading;

public class BaseActivity
{
    
    // Attributes
    private string _name;
    private string _description;
    private int _duration;
    private DateTime _endTime;

    // Constructor
    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Methods
    protected void StartActivity()
    {
        // Start timer and description
        Console.Clear();
        // Activity name and description
        Console.WriteLine($"Welcome to the {_name}. \n");
        Console.WriteLine($"{_description} \n");
        // Obtain user second duration
        ObtainDuration();

        // Get Ready message and spinner for 3 seconds
        DisplaySpinnerMessage("Get Ready...",3);
        Console.Clear();
    }

    protected void DisplayEnding()
    {
        // Dipslay end message
        Console.WriteLine();
        DisplaySpinnerMessage("Well Done!", 3);
        Console.Clear();
        DisplaySpinnerMessage($"\nYou have completed another {_duration} seconds of the {_name}.",3);
    }


    protected void StartTime()
    {
        // Using DateTime.Now.AddSeconds(_duration)
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    protected bool HasTimerExpired()
    {
      // Check if DateTime.now is >= _endTime 
      return DateTime.Now >= _endTime;
    }

    protected void ObtainDuration()
    {
        // using DateTime.now.Addseconds and console.ReadLine obtain duration
        Console.Write("How long, in seconds, would you like for your session? "); 
        string userDuration = Console.ReadLine(); 
        // Parse User Input for Duration
        _duration = int.Parse(userDuration);
    }

    protected void RunCountDownMessage(string message, int seconds)
    {
        // turn off cursor
        Console.CursorVisible = false;
        for (int i = seconds; i > 0; i--)
        {
            string displayMessage = $"{message} {i}";
            Console.Write(displayMessage);
            Thread.Sleep(1000);
            
            // Clear
            Console.Write(new string('\b', displayMessage.Length)); 
            Console.Write(new string(' ', displayMessage.Length)); 
            Console.Write(new string('\b', displayMessage.Length));
        }

        // Turn on cursor
        Console.CursorVisible = true;
    }

    protected void DisplaySpinnerMessage(string message, int seconds)
    {
        // Turn off cursor
        Console.CursorVisible = false;
        // Display message and spinner (provided by Gary Godderidge /*)
        //*
         Console.Write($"{message} ");
        string spinnerAnimation = "-\\|/";
        int index = 0;
        
        DateTime stopTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < stopTime)
        {
            Console.Write($"{spinnerAnimation[index++ % spinnerAnimation.Length]}");
            Thread.Sleep(250);
             Console.Write("\b \b");
        }
        //*
        // Turn on cursor
        Console.CursorVisible = true;
    }

    public string GetPromptString(List<ListingPrompts> prompts)
    {
        List<ListingPrompts> unused = new List<ListingPrompts>();

        foreach (ListingPrompts prompt in prompts)
        {
            if (!prompt.GetHasBeenUsed() == false)
            {
                unused.Add(prompt);
            }
        }

        // Reset Prompts
        if (unused.Count == 0)
        {
            foreach(ListingPrompts prompt in prompts)
            {
                prompt.SetHasBeenUsed(false);
            }
            unused = prompts;
        }


        // select a random prompt
        Random rand = new Random(); 
        int index = rand.Next(unused.Count); 
        ListingPrompts selected = unused[index]; 
        selected.SetHasBeenUsed(true); 
        
        return selected.GetPromptString();
    }

}