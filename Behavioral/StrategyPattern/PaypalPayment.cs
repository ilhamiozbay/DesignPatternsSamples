namespace StrategyPattern
{
    // UML diyagramındaki ConcreteStrategy sınıfına denk gelmektedir.
    // UML diyagramındaki Strategy arayüzüne denk gelen arayüzü uyguluyor.
    internal class PaypalPayment : IPayment
    {
        private readonly string _email;
        private readonly string _password;

        public PaypalPayment(string email, string password)
        {
            _email = email;
            _password = password;
        }

        public void Pay(int amount)
        {
            // Paypal ödeme işlemlerinin gerçekleştiği yer.
            Console.WriteLine("Paid by Paypal.");
        }
    }

    // UML diyagramındaki Context sınıfına denk gelmektedir.
    // UML diyagramındaki Strategy(IPayment) arayüzüne ait referansı tutmaktadır.
    internal class ShoppingCart
    {
        private List<Item> _items;
        private IPayment _payment;

        public ShoppingCart()
        {
            _items = new List<Item>();
        }

        public void SetPaymentMethod(IPayment payment)
        {
            _payment = payment;
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        private int _calculateTotal()
        {
            int total = 0;
            foreach (Item item in _items)
            {
                total += item.Price;
            }
            return total;
        }

        public void Pay()
        {
            int amount=_calculateTotal();

            _payment.Pay(amount);
        }
    }
}
