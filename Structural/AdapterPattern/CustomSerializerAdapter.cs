using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    // Daha sonradan dahil edilen yapının sisteme adepte edilmesi işlemi.
    // Sistemin kullandığı arayüzü uygular.
    // Bu sayede IJsonSerializer'i uygulayan bir sınıf örneği istendiğinde
    // bu sınıf örneğini vererek mevcut koda dokunmadan sistemin devam etmesi sağlaır.
    // UML diyagramındaki Adapter'a denk gelmektedir.
    internal class CustomSerializerAdapter : IJsonSerializer
    {
        public string SerializeObject(object value)
        {
            CustomSerializer serializer = new CustomSerializer();
            return serializer.Serialize(value);
        }
    }
}
