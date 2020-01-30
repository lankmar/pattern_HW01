using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_1._04._4_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.MySingleton;
            Singleton singleton2 = Singleton.MySingleton;
        }
    }
}
