using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    // Klonlamak istediğimiz sınıflarımıza uygulayacağımız arayüz.
    // Farklı sınıflarda da kullanılması için Generic bir yapı oluşturuldu.
    // Generic yapı sayesinde dinamik olarak tip dönüşümü sağlanacaktır.
    // Bu sayede farklı sınıflara da bu deseni uygulama şansı doğuyor.
    interface IClonablePrototype<TPrototype>
    {
        TPrototype Clone();
    }

    // Employee sınıfına klonlama yeteneği kazandırmak için tanımladığımız arayüzü uyguladık.
    internal class Employee : IClonablePrototype<Employee>
    {
        string _firstName;
        string _lastName;

        public Employee(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public Employee Clone()
        {
            return base.MemberwiseClone() as Employee;
            //return (Employee)this.MemberwiseClone();
        }
    }
}
