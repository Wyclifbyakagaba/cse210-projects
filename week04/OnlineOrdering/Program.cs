using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main Street", "Phoenix", "Arizona", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        List<Product> products1 = new List<Product>
        {
            new Product("Laptop", "P100", 800.00, 1),
            new Product("Mouse", "P101", 25.00, 2),
            new Product("Keyboard", "P102", 45.00, 1)
        };

        Order order1 = new Order(products1, customer1);

        Address address2 = new Address("45 King Road", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Mary Johnson", address2);

        List<Product> products2 = new List<Product>
        {
            new Product("Phone", "P200", 600.00, 1),
            new Product("Charger", "P201", 20.00, 3),
            new Product("Earbuds", "P202", 50.00, 2)
        };

        Order order2 = new Order(products2, customer2);

        Console.WriteLine("ORDER 1");
        Console.WriteLine("--------------------");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():F2}");

        Console.WriteLine();

        Console.WriteLine("ORDER 2");
        Console.WriteLine("--------------------");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():F2}");
    }
}
