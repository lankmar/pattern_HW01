using System;
using System.Collections.Generic;
using System.Text;

//2. Реализовать программу из раздела «Повторяющиеся фрагменты кода» с помощью делегата Func.
namespace HomeWork_1
{
    class Task2
    {
    }
    class Program
    {
        public static readonly string Address = Constants.Address;
        public static readonly string Format = Constants.Format;
        private static void DummyFunc()
        {
            WriteToConsole("Петя", "школьный друг", 30);
        }

        private static void DummyFuncAgain()
        {
            WriteToConsole("Вася", "сосед", 54);
        }

        private static void DummyFuncMore()
        {
            WriteToConsole("Николай", "сын", 4);
        }

        private static void WriteToConsole(string name, string description,
                                           int age)
        {
            Console.WriteLine(Format, name, description, Address, age);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Начало работы метода DummyFunc");
            DummyFunc();
            Console.WriteLine("Окончание работы метода DummyFunc");

            Console.WriteLine("Начало работы метода DummyFuncAgain");
            DummyFuncAgain();
            Console.WriteLine("Окончание работы метода DummyFuncAgain");

            Console.WriteLine("Начало работы метода DummyFuncMore");
            DummyFuncMore();
            Console.WriteLine("Окончание работы метода DummyFuncMore");

            Console.ReadLine();
        }
    }
}
