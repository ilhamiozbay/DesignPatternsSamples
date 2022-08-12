// Strategy tasarım deseni, bir algoritma ailesi tanımlamamızı, her birini ayrı bir sınıfa koymamızı ve nesnelerinin birbiriyle değiştirilebilir hale getirmenizi sağlayan davranışsal bir tasarım modelidir.

using StrategyPattern;

ShoppingCart shoppingCart = new ShoppingCart();
shoppingCart.AddItem(new Item("7342838382", 80));
shoppingCart.AddItem(new Item("7343738932", 20));

shoppingCart.SetPaymentMethod(new PaypalPayment("ilhami@abc.com","some_pass"));
shoppingCart.Pay();

shoppingCart.SetPaymentMethod(new CreditCartPayment("Julia Rodriguez", "4373093149845972", 
                                                    "199", "12/2024"));
shoppingCart.Pay();

