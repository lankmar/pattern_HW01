using System;
//2. Реализовать шаблон «Одиночка» для многопоточной программы с использованием класса Lazy<T>.

namespace HomeWork_1._04._4_02
{
    public class Singleton
    {
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(InitSingletonObject);

        static Singleton InitSingletonObject()
        {
            return new Singleton();
        }

        public static Singleton Instance { get { return lazy.Value; } }

        private Singleton() { }
    }
}
