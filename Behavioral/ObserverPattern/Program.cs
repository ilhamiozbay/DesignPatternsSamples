// Observer tasarım deseni, bir nesnede meydana gelen değişikliği içinde bulunduğu listedeki tüm elemanlara bildiren tasarım desenidir.

using ObserverPattern;

// Güncellemeden etkilenecek olan sınıf örnekleri.
IObserverUser observer1 = new ObserverUser();
IObserverUser observer2 = new ObserverUser();
IObserverUser observer3 = new ObserverUser();
IObserverUser observer4 = new ObserverUser();

// İzlenecek olan sınıf örneği.
Samsung samsung = new Samsung();

// İzlenecek olan sınıfa etkilenecek olan nesnelerin atanması.
samsung.AddObserver(observer1);
samsung.AddObserver(observer2);
samsung.AddObserver(observer3);
samsung.AddObserver(observer4);

samsung.ChangePrice();

