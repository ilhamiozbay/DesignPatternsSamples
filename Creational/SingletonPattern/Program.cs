// Bir sınıfın sadece bir örneği olmalıdır ve bu örneğe global bir erişim noktası sağlanmalıdır.

using SingletonPattern;

int testLength = 10;
List<LazyLogger> loggerList = new List<LazyLogger>();
List<Thread> threadList = new List<Thread>();

for (int i = 0; i < testLength; i++)
{
    if (i == testLength) break;
    threadList.Add(new Thread(() => { loggerList.Add(LazyLogger.GetInstance()); }));
}
foreach (var item in threadList)
{
    item.Start();
}
foreach (var item in threadList)
{
    item.Join();
}

for (int i = 0; i < loggerList.Count - 1; i++)
{
    Console.WriteLine($"logger{i}==logger{i + 1} ? " + (loggerList[i] == loggerList[i + 1]));
    Console.WriteLine($"logger{i}.Equals(logger{i + 1}) ? " + (loggerList[i]?.Equals(loggerList[i + 1])));
    Console.WriteLine($"logger{i} Guid = " + loggerList[i]?.LoggerGuid);
}
