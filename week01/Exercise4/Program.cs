using System;

class Exercise4
{
    static void Main()
    {
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date", "Elderberry" };
        //Display the list of fruits
        Console.WriteLine("List of Fruits:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        // remove an item banana
        fruits.Remove("Banana");
        // display the list of fruits after removing banana
        Console.WriteLine("\nList of Fruits after removing Banana:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}