// Facade tasarım deseni, bir alt sistemdeki arayüzlere bir birleşik arayüz sağlayarak alt sistemin kullanımını daha kolay hale getirmeyi amaçlar.
// Bu desendeki amaç karmaşık iş süreçlerini saklamaktır. Bunların yanı sıra algoritmalar, iş süreçleri vs. pek çok nesneden hizmet alarak ilerleyebilir. Bu detaylı bilgiler de bir nevi istemciden soyutlanmış olur.
//Özetle: amaç sistemi yeni bir alt yapıya sokmak değil, alt sınıflardaki karmaşıklığı soyutlayarak pratiklik sunmaktır.

using FacadePattern;

Customer customer1 = new("ilhami", "ozbay");
Customer customer2 = new("ozbay", "ilhami");

CreditCardFacade creditCardFacade = new CreditCardFacade();

creditCardFacade.CreateCreditCard(customer1);
creditCardFacade.CreateCreditCard(customer2);
