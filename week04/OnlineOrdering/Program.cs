using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Address addr1 = new Address("123 Main St", "New York", "NY", "USA");
        Address addr2 = new Address("456 King Rd", "Toronto", "ON", "Canada");
        Address addr3 = new Address("12 Federal Rd", "Lagos", "Ikeja", "Nigeria");

        
        Customer cust1 = new Customer("Elizabeth Johnson", addr1);
        Customer cust2 = new Customer("Chris Kalu", addr2);
        Customer cust3 = new Customer("TheTech Danny", addr3);

     
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Book", "P001", 12.50, 2));
        order1.AddProduct(new Product("Pen", "P002", 1.50, 5));

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Laptop", "P003", 800, 1));
        order2.AddProduct(new Product("Mouse", "P004", 25, 2));

        Order order3 = new Order(cust3);
        order3.AddProduct(new Product("IPhone", "13 ProMax", 900, 2));
        order3.AddProduct(new Product("Mouse", "P004", 25, 2));
        order3.AddProduct(new Product("Laptop", "P003", 600, 2));

      
        List<Order> orders = new List<Order> { order1, order2, order3 };

      
        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost()}\n");
        }
    }
}
