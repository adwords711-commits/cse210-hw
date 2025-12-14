using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    
    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);

    }
    public double TotalCost()
    {
        double total = 0;
        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }
        if (_customer.LiveInUS())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }
    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product p in _products)
        {
            label += $"{p.GetName()} (ID: {p.GetProductId()})\n";
        }
        return label;
    }
    public string ShippingLabel()
    {
        {
            return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress()}";
        }   
    }
    
}