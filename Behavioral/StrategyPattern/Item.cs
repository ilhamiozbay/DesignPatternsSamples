namespace StrategyPattern
{
    // Sepette bulunan ürünleri temsil eden sınıf.
    // Ürün kodu ve fiyat bilgisi temel olarak yeterlidir.
    internal class Item
    {
        private readonly string _upcCode;
        private readonly int _price;

        public Item(string upcCode, int price)
        {
            _upcCode = upcCode;
            _price = price;
        }

        public int Price { get { return _price; } private set { } }
    }
}
