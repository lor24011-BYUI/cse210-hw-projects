class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();


    public void DisplayJournal()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("\nNo journal entries to display.\n");
            return;
        }

        Console.WriteLine("\n--- Journal Entries ---");
        foreach (JournalEntry entry in _entries)
        {
            entry.DisplayJournalEntry();
        }
    }

    public void CreateEntry()
    {
        JournalEntry newEntry = new JournalEntry();
        newEntry.CreateJournalEntry();
        _entries.Add(newEntry);
    }
    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))

        {          

            foreach(JournalEntry entry in _entries)

            {

                outputFile.WriteLine(entry.CreateFileSystem());

            }
        Console.WriteLine($"\nJournal Saved to {filename}.\n");
        }
    }
    
    public void ReadFromFile(string filename)
    {

    if (!File.Exists(filename))
            {
                Console.WriteLine($"\nFile '{filename}' not found.\n");
                return;
            }

        string[] lines = System.IO.File.ReadAllLines(filename);


        foreach (string line in lines)

        {

            string[] parts = line.Split("#");


            JournalEntry entry = new JournalEntry();
                entry._date = parts[0];
                entry._prompt = parts[1];
                entry._response = parts[2];

                _entries.Add(entry);
            

            _entries.Add(entry);

        }
    }
}