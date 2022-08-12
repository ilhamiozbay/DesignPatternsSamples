namespace DecoratorPattern
{
    // UML diyagramındaki Component (IDataSource) arayüzünü uygular.
    // Constructor sayesinde özellikleri değiştirilmesi istenen nesnenin referansı tutulur.
    // Değiştirilmesini istediğimiz metotları abstract anahtar kelimesi ile işaretledik.
    // UML diyagramındaki BaseDecorator yapısına denk gelmektedir.
    abstract class BaseDataSourceDecorator : IDataSource
    {
        protected IDataSource _dataSource;

        protected BaseDataSourceDecorator(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public abstract string GetFileName();

        public abstract void ReadData();

        public abstract void WriteData(object data);
    }
}
