// Prototype tasarım deseni, mevcut nesnelerin prototiplerinin oluşturulmasını yani nesnelerin kopyalarını elde etmeyi sağlayan bir tasarım desenidir.

using PrototypePattern;

Employee employee1 = new Employee("ilhami", "ozbay");
Employee employee2=employee1.Clone();

// Aynı nesne örneklerini farklı referanslarda tutuyor.
// Birbirinin aynısı ve farklı referanslarda olan nesneler elde ettik.
Console.WriteLine(employee1 == employee2);
Console.WriteLine(employee1.Equals(employee2));

