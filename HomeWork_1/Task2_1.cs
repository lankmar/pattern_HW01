//Класс OrderRepository изначально был реализован для работы с заказами, хранящимися в MySQL.
//Но однажды нам потребовалось реализовать работу с данными о заказах, например, 
//через API стороннего веб-сервиса.Какие изменения нам надо будет внести?

namespace HomeWork_1
{
    public interface IOrderSource
    {
        Order Load(int orderId);
        void Save(Order order);
        void Update(Order order);
        void Delete(Order order);
    }

    class SQLSource : IOrderSource
    {
        public Order Load(int orderId)
        {
            return null;
        }
        public void Delete(Order order) { }  
        public void Save(Order order) { }
        public void Update(Order order) { }
    }

    class APISource : IOrderSource
    {
        public Order Load(int orderId)
        {
            return null;
        }
        public void Delete(Order order) { }
        public void Save(Order order) { }
        public void Update(Order order) { }
    }

    public class Order
    {
        int orderId;
        string Name;
    }

    class OrderRepository : IOrderSource
    {
        private IOrderSource orderSource;
        public OrderRepository(IOrderSource orderSource) => this.orderSource = orderSource;
        public Order Load(int orderId) { return new Order(); }
        public void Save(Order order) {  }
        public void Update(Order order) {  }
        public void Delete(Order order) { }
    }
}
