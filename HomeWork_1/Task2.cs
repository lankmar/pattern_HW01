using System;
using System.Collections.Generic;
using System.Text;

//2. Реализовать программу из раздела «Повторяющиеся фрагменты кода» с помощью делегата Func.
namespace HomeWork_1
{
    public class Constants
    {
        public static readonly string Address = "Москва, Россия";
        public static readonly string Format = "{0}  -  {1}, адрес {2}, возраст {3}";
    }
    class Task2
    {
        public static readonly string address = Constants.Address;
        public static readonly string format = Constants.Format;
        
        private static string DummyFunc()
        {
            return String.Format(format, "Петя", "школьный друг", address,  30);
        }

        private static string DummyFuncAgain()
        {
            return String.Format(format, "Вася", "сосед", address, 54);
        }

        private static string DummyFuncMore()
        {
            return String.Format(format, "Николай", "сын", address,  4);
        }

        public static void MakeFunc(Func<string> func)
        {
            string methodName = func.Method.Name;
            Console.WriteLine("Начало работы метода {0}", methodName);
            Console.WriteLine(func());
            Console.WriteLine("Окончание работы метода {0}", methodName);
        }

        public static IEnumerable<Func<string>> GetActionStep()
        {
            return new List<Func<string>>()
            {
                DummyFunc,
                DummyFuncAgain,
                DummyFuncMore
            };
        }
        
    }
}
