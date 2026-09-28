using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {


    // Tittle
    Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Intialize userNumber
        int userNumber = 0;
        // Imitialize sum
        int sumNumbers = 0;
        // Initialize average
        double avgNumber = 0;
        int listNumber = 0;
        // Initialize Largest number
        int largestNumber = 0;

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

        foreach (int num in numbers)
            {
                sumNumbers = sumNumbers + num;

                listNumber += 1;
                avgNumber = sumNumbers / listNumber;
                if (num > largestNumber)
                {
                    largestNumber = num;
                }
                
            }
        } while (userNumber != 0);

        // print Sum
        Console.WriteLine($"The Sum is: {sumNumbers}");

        // print Avg
        Console.WriteLine($"The average is: {avgNumber}");

        // print Largest Number
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}