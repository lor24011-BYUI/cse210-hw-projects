using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask and recieve Grade percentage from user
        Console.WriteLine("What is your Grade Percentage: ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);
    
        if (gradePercentage >= 90)
        {
            Console.WriteLine("Your letter grade is A");
        }

    }
}