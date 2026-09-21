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
    
        if (gradePercentage >= 90)
        {
            Console.WriteLine("Your letter grade is A");
        }
        else if (gradePercentage >= 80)
        {
            Console.WriteLine("Your letter grade is B");
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("Your letter grade is C");
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine("Your letter grade is D");
        }
        else if (gradePercentage <= 50)
        {
            Console.WriteLine("Your letter grade is F");
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("Congradulations! You passed this class!");
        }
        else if (gradePercentage < 70)
        {
            Console.WriteLine("Better Luck Next Time!");
        }
        


    }
}
