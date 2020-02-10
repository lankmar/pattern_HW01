using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_1._07
{
    public interface IShippingStrategy
    {
        double Calculate(Order order);
    }

    public class EMSShippingStrategy : IShippingStrategy
    { 
        public double Calculate (Order order) => 3;
    }
    public class FedExShippingStrategy : IShippingStrategy
    {
        public double Calculate(Order order) => 5;
    }

    public class UFSShippingStrategy : IShippingStrategy
    {
        public double Calculate(Order order) => 6;
    }

    public class ShippingCostCalculator
    {
        public double Calculate(Order order, Func<Order, double> shippingCostStratege) => shippingCostStratege(order);
    }

    public class CostCalculation
    {
        private readonly IShippingStrategy shippingStrategy;

        public CostCalculation(IShippingStrategy _shippingStrategy)
        {
            shippingStrategy = _shippingStrategy;
        }

        public double ShippingCostCalculation(Order order) => shippingStrategy.Calculate(order);
    }
}
