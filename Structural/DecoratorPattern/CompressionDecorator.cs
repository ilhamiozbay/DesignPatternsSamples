namespace DecoratorPattern
{
    // Yeni davranışların tanımlandığı sınıftır.
    // UML diyagramındaki BaseDecorator (BaseDataSourceDecorator) sınıfından türer.
    // UML diyagramındaki ConcreteDecorator sınıfına denk gelmektedir.
    class CompressionDecorator : BaseDataSourceDecorator
    {
        public CompressionDecorator(IDataSource dataSource) : base(dataSource)
        {
        }

        public override string GetFileName()
        {
            // Dosya adını okurken referansını tuttuğumuz sınıfın kendi davranışını sergilemesini istiyoruz.
            return base._dataSource.GetFileName();
        }

        public override void ReadData()
        {
            // Veriyi okurken referansını tuttuğumuz sınıfın kendi davranışını sergilemesini istiyoruz.
            base._dataSource.ReadData();
        }

        public override void WriteData(object data)
        {
            // Burada gelen veriye ait sıkıştırma işlemleri yapılacaktır.
            Console.WriteLine("Data compressed.");

            // Sıkıştırma işlemleri yapıldıktan sonra yazma işlemleri gerçekleştirilecektir.
            Console.WriteLine($"Compressed data was written to {base._dataSource.GetFileName()}.");
        }
    }
}
