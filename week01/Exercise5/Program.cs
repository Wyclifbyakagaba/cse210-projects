using System;

class Exercise5
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        //ask the user to enter a number
        Console.Write("Please enter a number: ");
        string input = Console.ReadLine();
        //convert the input to an integer
        int number = int.Parse(input);
        //display the number
        Console.WriteLine("You entered: " + number);
    }
}