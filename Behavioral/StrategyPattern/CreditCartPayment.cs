namespace StrategyPattern
{
    // UML diyagramındaki ConcreteStrategy sınıfına denk gelmektedir.
    // UML diyagramındaki Strategy arayüzüne denk gelen arayüzü uyguluyor.
    internal class CreditCartPayment : IPayment
    {
        private readonly string _name;
        private readonly string _cardNumber;
        private readonly string _cvv;
        private readonly string _dateOfExpiry;

        public CreditCartPayment(string name, string cardNumber, string cvv, string dateOfExpiry)
        {
            _name = name;
            _cardNumber = cardNumber;
            _cvv = cvv;
            _dateOfExpiry = dateOfExpiry;
        }

        public void Pay(int amount)
        {
            // Kredi kartı ödeme işlemlerinin gerçekleştiği yer.
            Console.WriteLine("Paid by credit card.");
        }
    }
}
