using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address addr1 = new Address("123 Main St", "New York", "NY", "USA");
        Address addr2 = new Address("456 King Rd", "Toronto", "ON", "Canada");

        // Create customers
        Customer cust1 = new Customer("Alice Johnson", addr1);
        Customer cust2 = new Customer("Bob Smith", addr2);

        // Create orders
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Book", "P001", 12.50, 2));
        order1.AddProduct(new Product("Pen", "P002", 1.50, 5));

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Laptop", "P003", 800, 1));
        order2.AddProduct(new Product("Mouse", "P004", 25, 2));

        // Store orders in a list
        List<Order> orders = new List<Order> { order1, order2 };

        // Display details for each order
        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost()}\n");
        }
    }
}
