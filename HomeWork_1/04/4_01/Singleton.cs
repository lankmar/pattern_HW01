using System;
//1. Реализовать шаблон «Одиночка» для многопоточной программы с использованием оператора lock.

namespace HomeWork_1._04._4_01
{
    public class Singleton
    {
        private static volatile Singleton mySingleton;
        private static object syncLock = new Object();

        private Singleton() { }

        public static Singleton MySingleton
        {
            get
            {
                if (mySingleton == null)
                {
                    lock (syncLock)
                    {
                        if (mySingleton == null)
                            mySingleton = new Singleton();
                    }
                }
                return mySingleton;
            }
        }
    }

    
}
 