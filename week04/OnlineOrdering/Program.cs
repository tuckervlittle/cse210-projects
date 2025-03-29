using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Waxilliam Ladrian", new Address("123 Copper Rd.", "New Seran", "Basin", "Scadrial"));
        Customer customer2 = new Customer("Wayne", new Address("456 Steel Way", "Elendel", "Basin", "Scadrial"));
        Customer customer3 = new Customer("Merasi Colms", new Address("789 Whispering Springs Ln.", "Tollhouse", "California", "USA"));

        Product product1 = new Product("Vindication", 0354635, 1035.99, 1);
        Product product2 = new Product("Sterion", 4516630, 599.99, 2);
        Product product3 = new Product("Suspended Steel", 3249838, 15.99, 3);
        Product product4 = new Product("Bowler Cap", 1000001, 10.99, 3);
        Product product5 = new Product("Gum", 0954984, 1.99, 4);
        Product product6 = new Product("Wooden Mask", 5467899, 150.99, 1);
        Product product7 = new Product("Medalion", 4389349, 68.99, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Order order3 = new Order(customer3);
        order3.AddProduct(product6);
        order3.AddProduct(product7);

        Console.Clear();
        Console.WriteLine(order1.GetPacking());
        Console.WriteLine(order1.GetShipping());
        Console.WriteLine();
        Console.WriteLine($"Total: ${order1.GetTotalCost()}");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine();
        Console.WriteLine(order2.GetPacking());
        Console.WriteLine(order2.GetShipping());
        Console.WriteLine();
        Console.WriteLine($"Total: ${order2.GetTotalCost()}");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine();
        Console.WriteLine(order3.GetPacking());
        Console.WriteLine(order3.GetShipping());
        Console.WriteLine();
        Console.WriteLine($"Total: ${order3.GetTotalCost()}");
        Console.WriteLine("-------------------------------------");
    }
}