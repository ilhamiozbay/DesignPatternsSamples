using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    // UML diyagramındaki Strategy arayüzüne denk gelmektedir.
    // Benzer işlemleri yapan sınıflar bu arayüzden türeyecektir.
    internal interface IPayment
    {
        void Pay(int amount);
    }


}
