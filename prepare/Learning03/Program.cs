using System;

class Program
{
    static void Main(string[] args)
    {
       Fraction f1 = new Fraction();     // 1/1
       Fraction f2 = new Fraction(5);    // 5/1
       Fraction f3 = new Fraction(3, 4); // 3/4
       Fraction f4 = new Fraction(1, 3); // 1/3

    // Fraction 1/1
       Console.WriteLine(f1.GetFractionString());
       Console.WriteLine(f1.GetDecimalValue());

    // Fraction 5/1
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

    // Fraction 3/4 
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

    // Fraction 1/3
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

    // Random Fractions up to 20
    Console.WriteLine("\n--- Random 20 Fractions ---\n");

    Fraction loopFraction = new Fraction();
    Random rand = new Random();

    for (int i = 1; i <= 20; i++)
        {
            int randomTop = rand.Next(1,10);
            int randomBottom = rand.Next(1,10);

            loopFraction.SetTop(randomTop);
            loopFraction.SetBottom(randomBottom);

            Console.WriteLine($"Fraction {i}: string: {loopFraction.GetFractionString()} Number: {loopFraction.GetDecimalValue()}");
        }
    }
}