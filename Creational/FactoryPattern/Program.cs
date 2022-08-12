// Factory tasarım deseni birbirleri ile ilişkili nesneleri oluşturmak için bir arayüz sağlar ve alt sınıfların hangi sınıfın örneğini oluşturacağına olanak sağlar.
// Factory (Fabrika) tasarım deseni sınıf örnekleme üzerine kurulu bir yapıdır.
// Birbirleri ile benzer yapıda olan nesnelerin nerede en verimli şekilde örnekleneceği problemine yanıt verir.

using FactoryPattern;

User user = new User() { Id = 1, Name = "ilhami", Mail = "ilhami@abc.com", Phone = "5010010101" };

NotifyFactory notifyFactory = new NotifyFactory();
INotify notify1 = notifyFactory.CreateNotify(NotifyType.SMS);
INotify notify2 = notifyFactory.CreateNotify(NotifyType.MAIL);
notify1.SendNotification(user);
notify2.SendNotification(user);


