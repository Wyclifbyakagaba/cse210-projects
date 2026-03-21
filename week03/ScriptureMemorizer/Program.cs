using System;

class Program
{
    static void Main(string[] args)
    {
        // EXCEEDING REQUIREMENTS:
// This program randomly selects a scripture and hides an increasing
// number of words each round for a more challenging memorization experience.
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference,
            "For God so loved the world that he gave his only begotten Son");

        while (true) 
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.AllHidden())
            {
                Console.WriteLine("\nAll words hidden. Program ending.");
                break;
            }

            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords();
        }
    }
}