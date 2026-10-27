using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ExceptionServices;

public class Scripture
{
    //attributes
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        //Split
        string[] splitText = text.Split(' ');
        foreach (string word in splitText)
        {
            _words.Add(new Word(word));
        }
    }

    public string GetDisplayString()
    {
        string textDisplay = "";
        foreach (Word word in _words)
        {
            textDisplay += word.GetWordString() + " ";
        }
        return $"{_reference.GetDisplayText()} {textDisplay.Trim()}";
    }
    
    public void HideRandomWords(int numberToHide)
    {
        // filter hidden words
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

    Random random = new Random();
        int hiddenCount = 0;

        // hide numberToHide if no more visible words
        while (hiddenCount < numberToHide && visibleWords.Count > 0)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index); // Remove from visible words list
            hiddenCount++;
        }
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false; 
            }
        }
        return true; 
    }
}