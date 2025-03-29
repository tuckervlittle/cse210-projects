using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public string GetCustomer()
    {
        return _name;
    }
    public bool IsInUSA()
    {
        return _address.InUSA();
    }
    public string GetShippingAddress()
    {
        return _address.GetAddress();
    }
}