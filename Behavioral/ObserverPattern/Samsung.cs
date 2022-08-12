using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    // Observable sınıfından türer.
    // UML diyagramındaki ConcreteObservable yapısına denk gelmektedir.
    internal class Samsung:ObservableProduct
    {
        // Ürün fiyatı değiştikten sonra Observer örneklerine bildirim gönderilir.
        public void ChangePrice()
        {
            // fiyat güncelleme işlemleri

            this._message.productName = "Samsung";
            this._message.message = "Samsung's price updated.";
            this.NotifyObserver();
        }
    }
}
