using System;
using System.Collections.Generic;
using System.Linq;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = products.Sum(p => p.GetPrice());
        total += customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        return string.Join("\n", products.Select(p => $"{p.GetName()} (ID: {p.GetId()})"));
    }

    public string GetShippingLabel()
    {
        return $"{customer.GetName()}\n{customer.GetAddress()}";
    }
}