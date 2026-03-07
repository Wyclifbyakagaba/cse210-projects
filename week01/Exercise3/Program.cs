using System;

class Exercise3
{
    static void Main()
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        // Prompt the user to enter a number
        Console.Write("Enter a number to count up to: ");
        int limit = int.Parse(Console.ReadLine());

        Console.WriteLine($"Counting from 1 to {limit}:");

        for (int i = 1; i <= limit; i++)
        {
            Console.WriteLine(i);
        }
    }
}
