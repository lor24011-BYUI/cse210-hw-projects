using System;

 public class Menu
{
    public int DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Start Breathing Activity");
        Console.WriteLine(" 2. Start Reflecting Activity");
        Console.WriteLine(" 3. Start Listing Activity");
        Console.WriteLine(" 4. Quit");

        // Recieve user input
        int choice = int.Parse(Console.ReadLine());
        if (choice >= 1 && choice <= 4)
        {
            return choice;
        }
        // Error catch
        return -1;
    }
}