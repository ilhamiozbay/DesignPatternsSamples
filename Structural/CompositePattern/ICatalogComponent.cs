
namespace CompositePattern
{
    // Soyut yapımızdır.
    // UML diyagramındaki Component kısmına denk gelmektedir.
    // Diğer istemci sınıflar bu yapıyı uygular.
    // Diğer sınıfların uygulayacağı hiyerarşiyi çizme metotunu içermektedir.
    internal interface ICatalogComponent
    {
        void DrawHierarchy();
    }
}