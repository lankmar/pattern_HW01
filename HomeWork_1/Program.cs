using System;
using System.Collections.Generic;

namespace HomeWork_1
{
    class Programm
    {
        static void Main(string[] args)
        {
            OrderRepository orderRepository = new OrderRepository(new APISource());
            orderRepository.Load(1);      

            Console.ReadLine();
        }
    }
}
