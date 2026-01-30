using System;

class Product
{
    private string name;
    private string id;
    private double price;
    private int quantity;

    //Constructor to initialize a product with name, ID, price, and quantity
    public Product(string name, string id, double price, int quantity)
    {
        this.name = name;
        this.id = id;
        this.price = price;
        this.quantity = quantity;
    }

    //Properties to access the attributes
    public string Name { get { return name; } }
    public string Id { get { return id; } }
    public double Price { get { return price; } }
    public int Quantity { get { return quantity; } }

    //Method for calculating the total cost of the product (price * quantity)
    public double CalculateTotalCost()
    {
        return price * quantity;
    }
}