
namespace CompositePattern
{
    // Somut yapımızdır.
    // UML diyagramındaki Composite kısmına denk gelmektedir.
    // Component (ICatalogComponent) listesi tutmaktadır.
    internal class ProductCatalog:ICatalogComponent
    {
        private string _name;
        private List<ICatalogComponent> _components;

        public ProductCatalog(string name)
        {
            _name = name;
            _components = new List<ICatalogComponent>();
        }

        internal void Add(ICatalogComponent catalogComponent)
        {
            _components.Add(catalogComponent);
        }

        internal void Remove(ICatalogComponent catalogComponent)
        {
            _components.Remove(catalogComponent);
        }

        // internal olursa:  'ProductCatalog' does not implement interface member 'ICatalogComponent.DrawHierarchy()'. 'ProductCatalog.DrawHierarchy()' cannot implement an interface member because it is not public.
        public void DrawHierarchy()
        {
            Console.WriteLine(_name);
            foreach (ICatalogComponent catalogComponent in _components)
            {
                catalogComponent.DrawHierarchy();
            }
        }

    } 
}