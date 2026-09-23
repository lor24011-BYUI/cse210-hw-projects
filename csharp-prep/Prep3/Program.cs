using System;

class Program
{
    static void Main(string[] args)
    {   
        // Title
        Console.WriteLine("Welcome to Guess My Number! \nEnter 0 to exit");

        // Ask User for Magic Number
        Console.Write("What is the magic number? ");
        string magicNumberString = Console.ReadLine();
        int magicNumber = int.Parse(magicNumberString);

        // Initialize magicGuess
        int magicGuess = 0;
        // Do-While loop (magicGuess != 0)
        do 
        {

            // Ask User for guess
            Console.Write("What is your guess? ");
            string magicGuessString = Console.ReadLine();
            magicGuess = int.Parse(magicGuessString);

            // Exit Number
            if (magicGuess == 0)
            {
                Console.WriteLine();
            }

            // Less then magicNumber
            else if (magicGuess < magicNumber)
            {
                Console.WriteLine("Higher ");
            }

            // Greater than magicNumber
            else if (magicGuess > magicNumber)
            {
                Console.WriteLine("Lower ");
            }

            // magicGuess == magicNumber
            else if (magicGuess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }

        } while (magicGuess != 0);
    }
}