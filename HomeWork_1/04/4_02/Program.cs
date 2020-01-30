using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_1._04._4_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;
        }
    }
}
