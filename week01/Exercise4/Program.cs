using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;
        int largest = numbers[0];

        foreach (int num in numbers)
        {
            sum += num;

            if (num > largest)
            {
                largest = num;
            }
        }

        double average = (double)sum / numbers.Count;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Largest number: {largest}");
    }
}
