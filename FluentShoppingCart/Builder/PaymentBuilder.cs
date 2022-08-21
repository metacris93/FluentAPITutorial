﻿using System;
using FluentShoppingCart.Entities;

namespace FluentShoppingCart.Builder
{
    public interface IPaymentBuilderStep1
    {
        IPaymentBuilderStep2 WithName(string name);
    }
    public interface IPaymentBuilderStep2
    {
        Payment WithSecurityCode(string code);
    }
    internal class PaymentBuilder : IPaymentBuilderStep1, IPaymentBuilderStep2
    {
        Payment _payment;
        public PaymentBuilder()
        {
            _payment = new();
        }

        public IPaymentBuilderStep2 WithName(string name)
        {
            _payment.Name = name;
            return this;
        }

        public Payment WithSecurityCode(string code)
        {
            _payment.SecurityCode = code;
            return _payment;
        }
    }
}

