using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        // step 1: create avariable to hold the name of the user
        string userName;
        int userAge;
        double height;
        // step 2: ask the user for their name and store it in the variable
        Console.Write("Please enter your name: ");
        userName = Console.ReadLine();
        // step 3: ask the user for their age and store it in the variable
        Console.Write("Please enter your age: ");
        userAge = int.Parse(Console.ReadLine());
        // step 4: ask the user for their height and store it in the variable
        Console.Write("Please enter your height (in meters): ");
        height = double.Parse(Console.ReadLine());
        // step 5: display the user's information
        Console.WriteLine($"Hello, {userName}! You are {userAge} years old and {height} meters tall.");
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}