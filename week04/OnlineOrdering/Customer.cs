using System;

class Customer
{
    private string name;
    private Address address;

    //Constructor to initialize client with name and address
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    //Properties to access the attributes
    public string Name { get { return name; } }
    public Address Address { get { return address; } }

    //Method to verify if the customer is in the USA
    public bool IsInUSA()
    {
        return address.IsInUSA();
    }
}