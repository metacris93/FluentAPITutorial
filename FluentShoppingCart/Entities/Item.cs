using System;
namespace FluentShoppingCart.Entities;

public class Item
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; internal set; }
}

