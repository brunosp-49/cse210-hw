using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main()
    {
        var order1 = new Order(new Customer("John Doe", new Address("123 Main St", "Anytown", "NY", "USA")));
        order1.AddProduct(new Product("Widget", 1, 19.99, 2));
        order1.AddProduct(new Product("Gadget", 2, 29.99, 1));

        Console.WriteLine("Order 1 Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Order 1 Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine("Order 1 Total: " + order1.GetTotalPrice());
        Console.WriteLine("\n-------------------------------------\n");

        var order2 = new Order(new Customer("Jane Smith", new Address("456 Elm St", "Othertown", "ON", "Canada")));
        order2.AddProduct(new Product("Thingamabob", 3, 14.99, 3));
        order2.AddProduct(new Product("Doodad", 4, 9.99, 4));

        Console.WriteLine("Order 2 Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Order 2 Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("Order 2 Total: " + order2.GetTotalPrice());
    }
}
