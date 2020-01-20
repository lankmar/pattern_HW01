//Товары в магазине могут иметь промокод, скидку, у них есть цена, состояние и т.д.Если этот товар – одежда, 
//то для нее устанавливается, из какого она материала, ее цвет и размер.Какие изменения нужно внести в код,
//чтобы описать произвольные товары (книги, автомобили и т.п.), соблюдая принципы SOLID?

using System.Drawing;

namespace HomeWork_1
{
    interface IItemPrice
    {
        void SetDiscount(double discount);
        void SetPromocode(string promocode);

        void SetPrice(double price);
    }
    interface ITypeClothes
    {
        void SetColor(Color color);
        void SetSize(Size size);
    }
    interface ITypeBook
    {
        void SetAuthor(string author);
        void SetBookTitle(string title);
    }
    class Clothes : IItemPrice, ITypeClothes
    {
        public void SetColor(Color color) { }
        public void SetDiscount(double discount) { }
        public void SetPrice(double price) { }
        public void SetPromocode(string promocode) { }
        public void SetSize(Size size) { }
    }

    class Book : IItemPrice, ITypeBook
    {
        public void SetDiscount(double discount) { }
        public void SetPrice(double price) { }
        public void SetPromocode(string promocode) { }
        void ITypeBook.SetAuthor(string author) { }
        void ITypeBook.SetBookTitle(string title) { }
    }
}
