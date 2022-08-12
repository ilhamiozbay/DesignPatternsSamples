using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    // Üst sınıfların uygulayacağı arayüzdür.
    // Yapılacak temel işlemler tanımlanmıştır.
    // UML diyagramındaki Component arayüzüne denk gelmektedir.
    internal interface IDataSource
    {
        string GetFileName();
        void WriteData(object data);
        void ReadData();
    }
}
