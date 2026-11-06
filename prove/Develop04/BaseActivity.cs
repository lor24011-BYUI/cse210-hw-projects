using System;

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
    }

    protected void DisplayEnding()
    {
        // Dipslay end message
    }

    protected void RunCountDownMessage(string message, int seconds)
    {
        // Take in a Message using activity and seconds using ObtainDuration
    }

    protected void DisplaySpinnerMessage(string message, int seconds)
    {
        // Display Message and Spinner for duratation
    }

    protected void StartTime()
    {
        // Using DateTime.Now.AddSeconds(ObtainDuration)
    }

    protected bool HasTimerExpired()
    {
      // Check if DateTime.now is < StartTime   
    }

    protected void ObtainDuration()
    {
        // using DateTime.now.Addseconds and console.ReadLine obtain duration
    }

    public string GetPromptString(List<ListingPrompts>)
    {
        
    }



}