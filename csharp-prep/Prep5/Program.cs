using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

    }
        
    
    //Display welcome message
    static void DisplayWelcome()
    {
            Console.WriteLine("Welcome to the Program");
    }

    // Ask and return userName
    static string UserName()
    {
        Console.WriteLine("What is your name? ");
        string userName =Console.ReadLine();

        return userName;
    }

    // Ask and recieve user number .parsed
    static int UserNumber()
    {
        Console.WriteLine("What is your favorit number? ");
        int userNumber = int.Parse(Console.ReadLine());

        return userNumber;
    }

    //
    static void UserBirthYear(out int userBirthYear)
    {
        Console.Write("Please enter the year you were born: ");
        userBirthYear = int.Parse(Console.ReadLine());

    }

    //
    static int SquareNumber(int userNumber)
    {
     int squareNumber = userNumber * userNumber;
     
     return squareNumber;
    }

    //
    static void DisplayResult(string userName,int squareNumber, int userBirthYear)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
        Console.WriteLine($"{userName}, you will turn {2026 - userBirthYear} this year.");
    }

 
}