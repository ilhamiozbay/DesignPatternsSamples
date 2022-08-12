using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    // Bildirilecek olan nesnelere paremetre olarak giden mesaj.
    // UML diyagramı ile ilgisi yoktur.
    internal class ProductUpdateMessage
    {
        public string productName;
        public string message;

        public override string ToString()
        {
            return $"{productName} updated. Message: {message}";
        }
    }
}
