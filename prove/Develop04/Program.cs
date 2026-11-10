using System;

public class Program
{
    
    // Main
    public static void Main(string[] args)
    {
        Menu menu = new Menu();
        bool run = true;

        while (run)
        {
            int choice = menu.DisplayMenu();

            switch(choice)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity(
                    "Breathing Activity",
                    "This activity will help you relax by walking you through breathing in and out slowly"
                    );
                    breathing.RunActivity();
                    break;
                
                case 2:
                    ReflectionActivity reflection = new ReflectionActivity(
                        "Reflection Activity",
                        "This activity will help you reflect on time in your life when you have shown stength and resilience."
                    );
                    reflection.RunActivity();
                    break;
                
                case 3:
                    ListingActivity listing = new ListingActivity(
                        "Listing Activity",
                        "This activity will help you reflect on the good things in your life by having you list as many things as you can to a prompt."
                    );
                    listing.RunActivity();
                    break;
                
                case 4:
                    run = false;
                    Console.WriteLine("\nThank you for using the Mindfullness Program");
                    break; 
            }
        }
    }
}