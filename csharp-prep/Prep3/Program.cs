using System;

class Program
{
    static void Main(string[] args)
    {   
        // Title
        Console.WriteLine("Welcome to Guess My Number!");

        // Ask User for Magic Number
        Console.Write("What is the magic number? ");
        string magicNumberString = Console.ReadLine();
        int magicNumber = int.Parse(magicNumberString);

        // Ask User for guess
        Console.Write("What is your guess? ");
        string magicGuessString = Console.ReadLine();
        int magicGuess = int.Parse(magicGuessString);

        // Less then magicNumber
        if (magicGuess < magicNumber)
        {
            Console.WriteLine("Higher ");
        }

        // Greater than magicNumber
        if (magicGuess > magicNumber)
        {
            Console.WriteLine("Lower ");
        }

        // magicGuess == magicNumber
        if (magicGuess == magicNumber)
        {
            Console.WriteLine("You guessed it!");
        }
    }
}