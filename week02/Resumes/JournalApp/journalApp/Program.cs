using System;

namespace JournalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your Journal!");
            
            // Example of journal input
            Console.WriteLine("Enter your journal entry:");
            string entry = Console.ReadLine();
            Console.WriteLine($"You wrote: {entry}");
        }
    }
}