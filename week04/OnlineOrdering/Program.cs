using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Address
        Address address1 = new Address("789 Oak Blvd", "Los Angeles", "CA", "USA");
        Address address2 = new Address("321 Birch Rd", "Vancouver", "BC", "Canada");

        //Customers
        Customer customer1 = new Customer("Carlo Rivera", address1);
        Customer customer2 = new Customer("Maria Gonzalez", address2);

        //Products
        Product product1 = new Product("Smartphone", "P001", 799, 2);
        Product product2 = new Product("Wireless Headphones", "P002", 120, 1);
        Product product3 = new Product("Desk Lamp", "P003", 35, 3);
        Product product4 = new Product("Bluetooth Speaker", "P004", 60, 2);

        //Create orders and add products
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        //Show order results
        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            //Print packaging label
            Console.WriteLine(order.GetPackingLabel());

            //Print shipping label
            Console.WriteLine(order.GetShippingLabel());

            //Print the total cost of the order
            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost()}\n");
        }
    }
}