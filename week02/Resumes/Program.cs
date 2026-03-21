using System;

class Program
{
    static void Main()
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        myJournal.LoadFromFile();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Exit");

            Console.Write("Choose an option: ");
            int.TryParse(Console.ReadLine(), out choice);

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
                    Console.WriteLine("Entry added!\n");
                    break;

                case 2:
                    myJournal.DisplayAll();
                    Console.WriteLine($"Total entries: {myJournal.CountEntries()}");
                    break;

                case 3:
                    myJournal.SaveToFile();
                    break;

                case 4:
                    myJournal.LoadFromFile();
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