class Menu
{
    
    public int ProcessMenu()
    {

        int input = 0 ;

        while (input < 1 || input > 5)
        {
            
            Console.WriteLine("Welcome to the Journal Program. ");

            Console.WriteLine("Create, Display, Save, or Read Journal Entries. ");
            Console.WriteLine("1. Create new journal entry. ");
            Console.WriteLine("2. Display all journal entries. ");
            Console.WriteLine("3. Save Journal to a file. ");
            Console.WriteLine("4. read jounral from a file. ");
            Console.WriteLine("5. quit ");
            Console.WriteLine("> ");

            input = int.Parse(Console.ReadLine());

        }
        return input;
    }

}