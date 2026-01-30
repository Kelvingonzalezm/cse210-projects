using System;

class Address
{
    //Private attributes for the address
    private string street;
    private string city;
    private string stateOrProvince;
    private string country;

    //Contructor to initialize the address
    public Address(string street, string city, string stateOrProvince, string country)
    {
        this.street = street;
        this.city = city;
        this.stateOrProvince = stateOrProvince;
        this.country = country;
    }

    //Properties to access the attributes
    public string Street { get { return street; } }
    public string City { get { return city; } }
    public string StateOrProvince { get { return stateOrProvince; } }
    public string Country { get { return country; } }

    //Method to check if the address is in the USA
    public bool IsInUSA()
    {
        return country == "USA";
    }

    //Method to obtain the complete address in string format
    public string GetFullAddress()
    {
        return $"{street}\n{city}, {stateOrProvince}\n{country}";
    }
}