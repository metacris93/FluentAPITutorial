using System;
namespace FluentShoppingCart.Entities;

public class Payment
{
    public string Name { get; internal set; }
    public string SecurityCode { get; internal set; }
}
