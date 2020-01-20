using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_1
{
    //1. Провести рефакторинг кода из раздела «Повторяющаяся логика», применяя внедрение зависимостей к классу EntityBase.
    public interface IIdGenerator
    {
        long CalculateId();
    }

    public class EntityBase
    {
        private readonly IIdGenerator idGenerator;

        public long Id { get; private set; }

        public EntityBase(IIdGenerator IdGenerator)
        {
            idGenerator = IdGenerator ?? throw new ArgumentNullException();
            Id = idGenerator.CalculateId();
        }
    }
 
    public class Customer : EntityBase
    {
        public string Description { get; set; }
        public Customer(IIdGenerator ideGenerator): base (ideGenerator) {  }
       
    }
    public class Store : EntityBase
    {
        public Store(IIdGenerator ideGenerator) : base(ideGenerator) { }   
    }

    public class DefaultIdGererator : IIdGenerator
    {
        public long CalculateId()
        {
            long id = DateTime.Now.Ticks;
            return id;
        }
    }
    

}
