﻿using System;
using FluentShoppingCart.Builder;
using FluentShoppingCart.Entities;

namespace FluentShoppingCart
{
    public class ShoppingCart
    {
        DateTime _dateCreated;
        List<Item> _items;
        Delivery _delivery;
        Payment _payment;
        Client _client;

        public Payment Payment { get => _payment; internal set => _payment = value; }
        public Delivery Delivery { get => _delivery; internal set => _delivery = value; }
        public Client Client { get => _client; internal set => _client = value; }
        public DateTime DateCreate { get => _dateCreated; }

        public static IClientBuilder Create()
        {
            var _builder = new ShoppingCartBuilder();
            return _builder;
        }
        internal ShoppingCart()
        {
            _dateCreated = DateTime.Now;
            _items = new();
        }
        internal void AddItem(Item item)
        {
            _items.Add(item);
        }
        public double Total
        {
            get
            {
                double total = 0;
                _items.ForEach(i => total += i.Price * i.Quantity);

                return total;
            }
        }
    }
}

