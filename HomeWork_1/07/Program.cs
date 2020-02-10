using System;
using System.Collections.Generic;
//1. Реализовать шаблон «Стратегия» без использования делегатов. 
//При решении задачи следует применить следующий интерфейс:
//public interface IShippingStrategy
//{
//    double Calculate(Order order);
//}

namespace HomeWork_1._07
{
    class Program
    {
        static void Main(string[] args)
        {
            IShippingStrategy ems = new EMSShippingStrategy();
            IShippingStrategy fedex = new FedExShippingStrategy();
            IShippingStrategy ufs = new UFSShippingStrategy();

            var costCalculation = new CostCalculation(ems).ShippingCostCalculation(new Order());

            Console.ReadLine();
        }
    }
}
