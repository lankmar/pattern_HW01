using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_1
{
    //1. Провести рефакторинг кода из раздела «Повторяющаяся логика», применяя внедрение зависимостей к классу EntityBase.
    class Task1
    {
    }

    public class Customer
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public Customer()
        {
            Id = CalculateId();
        }
        private long CalculateId()
        {
            long id = DateTime.Now.Ticks;
            return id;
        }
    }
    public class Store
    {
        public long Id { get; set; }
        public Store()
        {
            Id = CalculateId();
        }
        private long CalculateId()
        {
            long id = DateTime.Now.Ticks;
            return id;
        }
    }
}
