using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        myMenu.ProcessMenu();

        

        // Initialize Response
        int response = 0;
        // while loop
        while(response != 5)
        {
            //int response = myMenu.ProcessMenu();
            switch (response)
            {
                

                case 1:
                Console.WriteLine("Create");
                    // Call CreateJournalEntry()
                    break;

                case 2:
                Console.WriteLine("Display");
                    // Call DisplayJournal()
                    break;

                case 3:
                Console.WriteLine("Save");
                    // call ReadFromFile()
                    break;
                
                case 4:
                Console.WriteLine("Write");
                    // call WriteToFile()
                    break;
            }
        }
    }

}


//