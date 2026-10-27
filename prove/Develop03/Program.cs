using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Word myWord = new Word("Secret");

//         myWord.Display();
//         myWord.Hide();
//         myWord.Display();
//     }
// }

using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        Reference reference = new Reference("Jacob", 5, 42, 50);
        List<Scripture> library = new List<Scripture>();

        Reference ref1 = new Reference("Jacob", 5, 42);
        Scripture scripture1 = new Scripture(ref1, "And it came to pass that the Lord of the vineyard wept, and said unto the servant: What could I have done more for my vineyard?");
        library.Add(scripture1);

        Reference ref2 = new Reference("Jacob", 5, 50);
        Scripture scripture2 = new Scripture(ref2, "But, behold, the servant said unto the Lord of the vineyard: Spare it a little longer.");
        library.Add(scripture2);


        Random random = new Random();
        int randomIndex = random.Next(library.Count);
        Scripture selectedScripture = library[randomIndex];


        string userInput = "";
    
        while (userInput != "quit")
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayString());
            Console.WriteLine();

            // Check if all words are hidden
            if (selectedScripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden.");
                break;
            }

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine().Trim().ToLower();

            if (userInput != "quit")
            {
                // Hide 3 random words each time Enter is pressed
                selectedScripture.HideRandomWords(3);
            }
        }
    }
}