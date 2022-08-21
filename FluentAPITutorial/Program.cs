using FluentShoppingCart;

ShoppingCart cart = ShoppingCart.Create()
    .ForClient("Cristian Pisco")
    .AddItem(i => i.WithName("Producto 1").WithPrice(5).WithQuantity(1))
    .AddItem(i => i.WithName("Producto 2").WithPrice(5).WithQuantity(2))
    .Checkout()
    .SetDelivery(d => d.WithAddress("New Address").WithPostalCode("123456"))
    .SetPayment(p => p.WithName("VISA").WithSecurityCode("123"))
    .Process();