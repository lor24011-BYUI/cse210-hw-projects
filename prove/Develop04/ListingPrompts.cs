using System;

public class ListingPrompts
{
    private string _prompt;
    private bool _hasBeenUsed;

    public ListingPrompts(string prompt, bool used = false)
    {
        _prompt = prompt;
        _hasBeenUsed = used;
    }
    public string GetPromptString()
    {
        return _prompt;
    }
    public bool GetHasBeenUsed()
    {
        return _hasBeenUsed;
    }
    public void SetHasBeenUsed(bool used = true)
    {
        _hasBeenUsed = used;
    }
}