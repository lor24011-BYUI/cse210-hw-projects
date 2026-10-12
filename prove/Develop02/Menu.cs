class Menu
{
    public int ProcessMenu()
    {   
        //Title Line
        Console.WriteLine("Welcome to the Journal Program.");
        Console.WriteLine("Create, Display, Save, or Read Journal Entries.");

        int input = 0;

        while (input < 1 || input > 5)
        {   
            Console.WriteLine("1. Create new journal entry.");
            Console.WriteLine("2. Display all journal entries.");
            Console.WriteLine("3. Read journal to a file.");
            Console.WriteLine("4. Save journal from a file.");
            Console.WriteLine("5. Quit");
            Console.Write("> ");
            input = int.Parse(Console.ReadLine());
        }
        return input;
    }
}