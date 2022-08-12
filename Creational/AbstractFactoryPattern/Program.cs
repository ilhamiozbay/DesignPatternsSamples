// Abstract Factory tasarım deseni birbirleri ile ilişkili ürün ailesini oluşturmak için bir arayüz sağlar.

using AbstractFactoryPattern;

CustomOperation customOperation1 = new CustomOperation(new OracleDatabaseFactory());
CustomOperation customOperation2 = new CustomOperation(new MySqlDatabaseFactory());

customOperation1.RemoveById(1);
customOperation2.RemoveById(2);
