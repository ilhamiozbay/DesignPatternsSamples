namespace FacadePattern
{
    //Kredi kartı ile ilgili işlemlerin yapıldığı sınıf
    internal class CreditCardManager
    {
        public void CreateCreditCard(Customer customer)
        {
            // Parametre olarak gelen kullanıcıya ait kredi kartı oluşturma işleminin yapıldığı yer
            Console.WriteLine($"Credit card for {customer.FirstName} created.");
        }
    }
}
