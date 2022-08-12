using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    // Sisteme daha sonradan dahil olan yapı.
    // Sistemin kullandığı arayüzü uygulamamaktadır.
    // UML diyagramındaki Adaptee'ye denk gelmektedir.
    internal class CustomSerializer
    {
        public string Serialize(object value)
        {
            // Gelen nesneyi serilize etmek için temel operasyonel işlemler..
            // Daha sonradan da gerekli değerin geri döndürülmesi...
            return "serialized with CustomSerializer";
        }
    }
}
