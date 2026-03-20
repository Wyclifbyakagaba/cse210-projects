using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("\n--- Journal Menu ---");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Quit");
            Console.Write("Enter choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine() ?? "";

                    Entry entry = new Entry
                    {
                        _date = DateTime.Now.ToShortDateString(),
                        _promptText = prompt,
                        _entryText = response
                    };

                    myJournal.AddEntry(entry);
                    Console.WriteLine(" Entry added!\n");
                    break;

                case 2:
                    myJournal.DisplayAll();
                    Console.WriteLine($"Total entries: {myJournal.CountEntries()}");
                    break;

                case 3:
                    Console.Write("Enter filename to save (e.g., journal.txt): ");
                    string saveFile = Console.ReadLine() ?? "journal.txt";
                    myJournal.SaveToFile(saveFile);
                    break;

                case 4:
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine() ?? "journal.txt";
                    myJournal.LoadFromFile(loadFile);
                    break;

                case 5:
                    Console.WriteLine("Exiting program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
        }
    }
}