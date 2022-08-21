using System;
using FluentShoppingCart.Entities;

namespace FluentShoppingCart.Builder
{
    public interface IItemBuilderStep1
    {
        IItemBuilderStep2 WithName(string name);
    }
    public interface IItemBuilderStep2
    {
        IItemBuilderStep3 WithPrice(double price);
    }
    public interface IItemBuilderStep3
    {
        Item WithQuantity(int quantity);
    }
    internal class ItemBuilder : IItemBuilderStep1, IItemBuilderStep2, IItemBuilderStep3
    {
        Item _item;
        public ItemBuilder()
        {
            _item = new();
        }

        public IItemBuilderStep2 WithName(string name)
        {
            _item.Name = name;
            return this;
        }

        public IItemBuilderStep3 WithPrice(double price)
        {
            _item.Price = price;
            return this;
        }

        public Item WithQuantity(int quantity)
        {
            _item.Quantity = quantity;
            return _item;
        }
    }
}

