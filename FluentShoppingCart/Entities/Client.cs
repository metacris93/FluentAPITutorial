namespace FluentShoppingCart.Entities;

public class Client
{
    public string Name { get; internal set; }
    internal Client(string name)
    {
        this.Name = name;
    }
}

