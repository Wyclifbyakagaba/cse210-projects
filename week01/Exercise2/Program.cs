using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        // Ask the user to enter a number
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        // Check if the number is even or odd
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is an even number.");
        }
        else
        {
            Console.WriteLine($"{number} is an odd number.");
        }
            
            if (number % 3 == 0)
                {
                    Console.WriteLine($"{number} is also divisible by 3.");
                }
            }
        }
    
