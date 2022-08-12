using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    // Değişimden etkilenecek, izleyecek olan sınıfların uyguladığı arayüzdür.
    // UML diyagramındaki Observer yapısına denk gelmektedir.
    internal interface IObserverUser
    {
        void SendNotification(ProductUpdateMessage message);
    }

    // Observer arayüzünü uygulayan, değişimi takip eden sınıflardır.
    // Değişim update metotu ile bildirilir.
    // UML diyagramındaki ConcreteObserver yapısına denk gelmektedir.
    internal class ObserverUser : IObserverUser
    {
        public void SendNotification(ProductUpdateMessage message)
        {
            Console.WriteLine(message.ToString());
        }
    }
}
