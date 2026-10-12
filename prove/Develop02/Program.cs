using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        Journal myJournal = new Journal();
        

        int response = 0;

        while(response != 5)
        {
            response = myMenu.ProcessMenu();
            switch(response)
            {
                case 1:
                    myJournal.CreateEntry();
                    break;
                case 2:
                    myJournal.DisplayJournal();
                    break;
                case 3:
                    Console.WriteLine("Save");
                    // Call ReadFromFile()
                    break;
                case 4:
                    Console.WriteLine("Write");
                    // call WriteToFile
                    break;
            }
        }
    }
}