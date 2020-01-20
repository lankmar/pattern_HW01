using System;
using System.Collections.Generic;

namespace HomeWork_1
{
    class Programm
    {
        static void Main(string[] args)
        {
           //задание 1
            Store store = new Store(new DefaultIdGererator());

            Console.WriteLine(store.Id.ToString());
            Console.ReadLine();

            //задание 2
            IEnumerable<Func<string>> funcs = Task2.GetActionStep();
            foreach (var item in funcs)
            {
                Task2.MakeFunc(item);
            }

            Console.ReadLine();
        }
    }
}
