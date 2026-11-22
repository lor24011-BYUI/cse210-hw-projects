using System;
using System.Linq.Expressions;

public class Menu 
{
    private ListGoals _goals = new ListGoals();

    public void start()
    {
        string choice = "";

        while (choice != "6")
        {
           Console.WriteLine($"\nYou have {_goals.GetScore()} points.\n"); 
           Console.WriteLine("Menu Options:"); 
           Console.WriteLine(" 1. Create New Goal"); 
           Console.WriteLine(" 2. List Goals"); 
           Console.WriteLine(" 3. Save Goals"); 
           Console.WriteLine(" 4. Load Goals"); 
           Console.WriteLine(" 5. Record Event"); 
           Console.WriteLine(" 6. Quit"); 
           Console.Write("Select a choice from the menu: "); 

           choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoalMenu();
            }
            else if (choice == "2")
            {
                _goals.DisplayGoals();
            }
            else if (choice == "3")
            {
                Console.WriteLine("What is the filename for the goal file? \n");
                string filename = Console.ReadLine();
                _goals.SaveGoals(filename);
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename for the Saved goal file? \n");
                string filename = Console.ReadLine();
                _goals.LoadGoals(filename);
            }
            else if (choice == "5")
            {
                _goals.DisplayGoals();
                Console.WriteLine("Which goal did you Complete? \n");
                int goalNum = int.Parse(Console.ReadLine());
                _goals.RecordEvent(goalNum);
            }
            else if (choice == "6")
            {
                Console.WriteLine("Thank You for making your Goals!");
            }
            else
            {
                Console.WriteLine("Invalid Option, Please try again.");
            }
        }
    }

    // Goal Menu
    private void CreateGoalMenu()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.WriteLine("Which type of Goal would you like to make? (Please Enter the Number to select) ");

        // Goal type selection
        string typeChoice = Console.ReadLine();

        // Goal Name
        Console.WriteLine("What is the name of your goal? ");
        string name = Console.ReadLine();

        // Goal description
        Console.WriteLine("What is a short description of your goal? ");
        string description = Console.ReadLine();

        // Goal Points
        Console.WriteLine("What is the amount of points this goal is worth? ");
        int points = int.Parse(Console.ReadLine());

        if (typeChoice == "1")
        {
            _goals.AddGoal(new SimpleGoal(name, description, points));
        }
        if (typeChoice == "2")
        {
            _goals.AddGoal(new EternalGoal(name, description, points));
        }
        if (typeChoice == "3")
        {
            Console.WriteLine("How many times to complete for Bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine("What ist he Bonus for completeing this Goal? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.AddGoal(new CheckListGoal(name, description, points, target, bonus));
        }
    }
}