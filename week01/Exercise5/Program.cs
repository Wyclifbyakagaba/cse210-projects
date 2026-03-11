using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string name = GetName();
        int number = GetFavoriteNumber();

        int squared = SquareNumber(number);

        Console.WriteLine($"{name}, the square of your number is {squared}");
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string GetName()
    {
        Console.Write("Enter your name: ");
        return Console.ReadLine();
    }

    static int GetFavoriteNumber()
    {
        Console.Write("Enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }
}
