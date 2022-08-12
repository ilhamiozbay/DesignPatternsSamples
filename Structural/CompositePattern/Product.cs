
namespace CompositePattern
{
    // Somut yapımızdır.
    // UML diyagramındaki Leaf kısmına denk gelmektedir.
    // Hiyerarşinin en alt tabakasını temsil etmektedir.
    internal class Product:ICatalogComponent
    {
        private string _name;

        public Product(string name)
        {
            _name = name;
        }

        public void DrawHierarchy()
        {
            Console.WriteLine(_name);
        }
    }
}