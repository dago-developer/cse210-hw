using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var customer1 = new Customer("Alice Johnson", new Address("123 Maple St", "New York", "NY", "USA"));
        var customer2 = new Customer("Carlos Ramirez", new Address("456 Oak Ave", "Mexico City", "CDMX", "Mexico"));

        var order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "WM001", 25.99m, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "KB001", 75.49m, 1));

        var order2 = new Order(customer2);
        order2.AddProduct(new Product("Laptop Stand", "LS001", 19.99m, 1));
        order2.AddProduct(new Product("USB-C Hub", "UH001", 29.99m, 3));

        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.CalculateTotal():F2}");
        Console.WriteLine(new string('-', 40)); //Remember that this its a separator line !!!!
    }
}
