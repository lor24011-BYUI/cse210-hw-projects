using System;

class Program
{
    static void Main(string[] args)
    {   
        // Title
        Console.WriteLine("Welcome to Guess My Number!");

        /* Ask User for Magic Number
        Console.Write("What is the magic number? ");
        string magicNumberString = Console.ReadLine();
        int magicNumber = int.Parse(magicNumberString);
        */

        // Produce a random magicNumber from 1 - 100
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        // Initialize User Continue
        string userContinue = "yes";

        // Initialize magicGuess
        int magicGuess = 0;

        // Initialize
        int guessTotal = 0;

        // Do-While loop (userContinue == yes)
        do 
        {
            // Do-While loop (magicGuess != magicNumber)
            do 
            {

                // Ask User for guess
                Console.Write("What is your guess? ");
                string magicGuessString = Console.ReadLine();
                magicGuess = int.Parse(magicGuessString);
                guessTotal++ ;

                /* Exit Number
                if (magicGuess == 0)
                {
                    Console.WriteLine();
                }
                */

                // Less then magicNumber
                if (magicGuess < magicNumber)
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
                    Console.WriteLine($"It took {guessTotal} guesses");
                    Console.Write("Would you like to continue? yes/no : ");
                    userContinue = Console.ReadLine();

                    if (userContinue == "yes")
                    {
                        guessTotal = 0;
                    }
                }

            } while (magicGuess != magicNumber);
        } while (userContinue == "yes");
    }
}