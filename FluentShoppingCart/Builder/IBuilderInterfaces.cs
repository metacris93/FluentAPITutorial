using System;
using FluentShoppingCart.Entities;

namespace FluentShoppingCart.Builder
{
    public interface IItemsBuilder
    {
        IItemsBuilder AddItem(Func<IItemBuilderStep1, Item> itemConfigurator);
        ICheckoutBuilder Checkout();
    }

    public interface IClientBuilder
    {
        IItemsBuilder ForClient(string name);
    }
    public interface ICheckoutBuilder
    {
        IDeliveryBuilder SetDelivery(Func<IDeliveryBuilderStep1, Delivery> deliveryConfigurator);
    }
    public interface IDeliveryBuilder
    {
        IPaymentBuilder SetPayment(Func<IPaymentBuilderStep1, Payment> paymentConfigurator);
    }

    public interface IPaymentBuilder
    {
        public ShoppingCart Process();
    }

}

