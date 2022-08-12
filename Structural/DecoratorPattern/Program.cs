// Decorator tasarım deseni, nesnelere dinamik olarak yeni sorumluluklar atamamızı sağlayan tasarım desenidir.

using DecoratorPattern;

IDataSource dataSource = new FileDataSource("data.sql");

IDataSource compressedDataSource = new CompressionDecorator(dataSource);

compressedDataSource.ReadData();
compressedDataSource.WriteData(new object());

