using System;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double GetTotalCost()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.TotalCost();
        }
        total += _customer.IsInUSA() ? 5 : 35;
        return total;
    }
    public string GetShipping()
    {
        return $"Shipping Label:\n{_customer.GetCustomer()}\n{_customer.GetShippingAddress()}";
    }
    public string GetPacking()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += product.GetPackingInfo();
        }
        return label;
    }
}