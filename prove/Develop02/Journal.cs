class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();


    public void DisplayJournal()
    {
        foreach(JournalEntry entry in _entries)
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

        }
    }
    
    public void ReadFromFile(string filename)
    {
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