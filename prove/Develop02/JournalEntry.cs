class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;


    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine(_response);
        Console.WriteLine();
    }

    public void CreateJournalEntry()
    {
        string [] prompts =
        {
            "How Was your day.",
            "Talk about someone you met.",
            "What is one thing you would do diffrently today?",
            "What hapened today?",
            "What emotions did you fell today?",
            "What was the best part of your day?"
        };

        //Random Int
        Random random = new Random();
        int index = random.Next(prompts.Length);

        //Date and prompt
        _date = DateTime.Now.ToString();
        _prompt = prompts[index];

        //Display / read
        Console.Write($"\nPrompt: {_prompt}: ");
        _response = Console.ReadLine();
        
    }


    public string CreateFileSystem()
    {
         string outputString = "";


        outputString = $"{_date}#{_prompt}#{_response}";

        return outputString;
    }

}