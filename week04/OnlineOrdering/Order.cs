using System;
using System.Collections.Generic;

class Order
{
    private List<Product> products;
    private Customer customer;

    //Constructor to initialize the order with a customer
    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    //Method for adding products to the order
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    //Method for calculating the total cost of the order (products + shipping)
    public double CalculateTotalCost()
    {
        double total = 0;

        //Add up the total cost of each product
        foreach (Product product in products)
        {
            total += product.CalculateTotalCost();
        }

        //Calculate shipping cost based on customer location
        double shippingCost;
        if (customer.IsInUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        //Add shipping cost to total
        total += shippingCost;

        return total;
    }

    //Method for generating the packaging label(products in the order)
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";

        foreach (Product product in products)
        {
            label += $"Product Name: {product.Name}, ID: {product.Id}\n";
        }
        return label;
    }

    //Method for generating the shippig label (customer information)
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.Name}\n{customer.Address.GetFullAddress()}\n";
    }
}