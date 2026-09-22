using System;

class Program
{
    static void Main(string[] args)
    {   
        // Initialize strings
        string firstName;
        string lastName;

        // Print to terminal and recieve string from user
        Console.WriteLine("Please enter your first name: ");
        firstName = "Young";
        Console.WriteLine("Please enter your last name: ");
        lastName = "Brigham";

        // Format string and print to terminal
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}