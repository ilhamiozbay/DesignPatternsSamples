using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    // Takip edilecek olan yapımızdır.
    // İçerisinde Observer (değişimden etkilenecek) nesneleri tutar.
    // UML diyagramındaki Observable yapısına denk gelmektedir.
    internal abstract class ObservableProduct
    {
        private List<IObserverUser> _users;
        protected ProductUpdateMessage _message;

        public ObservableProduct()
        {
            _users = new List<IObserverUser>();
            _message = new ProductUpdateMessage();
        }

        public void AddObserver(IObserverUser observerUser)
        {
            _users.Add(observerUser);
        }

        public void RemoveObserver(IObserverUser observerUser)
        {
            _users.Remove(observerUser);
        }

        public void NotifyObserver()
        {
            foreach (IObserverUser observerUser in _users)
            {
                observerUser.SendNotification(_message);
            }
        }
    }
}
