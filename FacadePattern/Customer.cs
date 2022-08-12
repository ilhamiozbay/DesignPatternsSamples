using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    // Banka müşterimizi temsili oluşturan sınıf
    internal class Customer
    {
        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    internal class CreditCardFacade
    {
        public void CreateCreditCard(Customer customer)
        {
            CreditCardManager creditCardManager = new CreditCardManager();
            BlackListService blackListService = new BlackListService();

            if (!blackListService.CheckIfTheEmployeeIsInTheBlackList(customer))
            {
                creditCardManager.CreateCreditCard(customer);
            }
            else
            {
                Console.WriteLine($"{customer.FirstName} is in the blacklist.");
            }
        }
    }
}
