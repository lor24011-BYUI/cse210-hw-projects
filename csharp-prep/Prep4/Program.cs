using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {


    // Tittle
    Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Intialize userNumber
        int userNumber = 0;

        //Do loop
        do
        {

        // Create new list
        List<int> numbers = new List<int>();

        //Read user input.
        Console.Write("Enter number: ");
        string userNumString = Console.ReadLine();

        // Parse string to int
        userNumber = int.Parse(userNumString);

        // Append to list numbers
        numbers.Add(userNumber);

        if (userNumber == 0)
            {
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
        } while (userNumber != 0);

    }
}