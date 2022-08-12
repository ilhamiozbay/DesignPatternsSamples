using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    // UML diyagramındaki Target'a denk gelmektedir.
    // Sistem bu arayüzü uygulayarak çalışmaktadır.
    internal interface IJsonSerializer
    {
        public string SerializeObject(object value);
    }
}
