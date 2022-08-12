// Composite tasarım deseni, nesneleri ağaç yapısına göre düzenleyerek ağaç yapısındaki alt üst ilişkisini kurmaya yarayan bir desendir.

using CompositePattern;

ProductCatalog items = new ProductCatalog("Ürünler");

ProductCatalog phones = new ProductCatalog("Telefonlar");

ProductCatalog iPhone = new ProductCatalog("iPhone Telefonlar");
ProductCatalog samsung = new ProductCatalog("Samsung Telefonlar");

Product iphone5Item = new Product("iPhone 5 Telefon");
Product samsungGalaxyItem = new Product("Samsung Galaxy Telefon");

items.Add(phones);

phones.Add(iPhone);
phones.Add(samsung);

iPhone.Add(iphone5Item);
samsung.Add(samsungGalaxyItem);

items.DrawHierarchy();

