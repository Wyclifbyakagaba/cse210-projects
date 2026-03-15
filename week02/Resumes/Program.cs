using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("\nJournal Menu");
            Console.WriteLine("1. Write New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Quit");
            Console.Write("Enter choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            if (choice == 1)
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Entry entry = new Entry
                {
                    _date = DateTime.Now.ToShortDateString(),
                    _promptText = prompt,
                    _entryText = response
                };

                journal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Filename to save (e.g., journal.txt): ");
                journal.SaveToFile(Console.ReadLine());
            }
            else if (choice == 4)
            {
                Console.Write("Filename to load: ");
                journal.LoadFromFile(Console.ReadLine());
            }
            else if (choice == 5)
            {
                Console.WriteLine("Exiting program.");
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }
}

