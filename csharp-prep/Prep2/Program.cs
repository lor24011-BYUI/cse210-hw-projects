using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Ask and recieve Grade percentage from user
        Console.WriteLine("What is your Grade Percentage: ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);
        string letterGrade = "";
    
        if (gradePercentage >= 90)
        {
            letterGrade = "Your letter grade is A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "Your letter grade is B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "Your letter grade is C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "Your letter grade is D";
        }
        else if (gradePercentage <= 50)
        {
            letterGrade = "Your letter grade is F";
        }
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congradulations! You passed this class!");
        }
        if (gradePercentage < 70)
        {
            Console.WriteLine("Better Luck Next Time!");
        }

        Console.WriteLine($"{letterGrade}");

    }
}
