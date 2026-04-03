// EXCEEDING REQUIREMENTS:
// - Added spinner animation
// - Random prompts and questions
// - Clean menu system
// - Could extend with activity trackingusing System;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().DoBreathing();
                    break;
                case "2":
                    new ListingActivity().DoListing();
                    break;
                case "3":
                    new ReflectingActivity().DoReflecting();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Press any key to try again...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}