using System;

class Program
{
    static void Main(string[] args)
    {
        int number = -1;
        int sum = 0;

        while (number != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            number = int.Parse(Console.ReadLine());

            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");
    }
}
