// Bir sınıfın sadece bir örneği olmalıdır ve bu örneğe global bir erişim noktası sağlanmalıdır.

using SingletonPattern;

Logger logger1 = null;
Logger logger2 = null;

Thread thread1 = new Thread(() => { logger1 = Logger.GetInstance(); });
Thread thread2 = new Thread(() => { logger2 = Logger.GetInstance(); });
thread1.Start();
thread2.Start();
thread1.Join();
thread2.Join();

Console.WriteLine("logger1==logger2 ? " + (logger1 == logger2));
Console.WriteLine("logger1.Equals(logger2) ? " + (logger1?.Equals(logger2)));
Console.WriteLine("logger1 Guid = " + logger1?.LoggerGuid);
Console.WriteLine("logger2 Guid = " + logger2?.LoggerGuid);
