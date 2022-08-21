﻿using System;
using FluentShoppingCart.Entities;

namespace FluentShoppingCart.Builder
{
    public interface IDeliveryBuilderStep1
    {
        IDeliveryBuilderStep2 WithAddress(string address);
    }
    public interface IDeliveryBuilderStep2
    {
        Delivery WithPostalCode(string code);
    }
    internal class DeliveryBuilder : IDeliveryBuilderStep1, IDeliveryBuilderStep2
    {
        Delivery _delivery;
        internal DeliveryBuilder()
        {
            _delivery = new();
        }

        public IDeliveryBuilderStep2 WithAddress(string address)
        {
            _delivery.Address = address;
            return this;
        }

        public Delivery WithPostalCode(string code)
        {
            _delivery.PostalCode = code;
            return _delivery;
        }
    }
}

