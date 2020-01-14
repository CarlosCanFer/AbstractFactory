namespace EjemploAbstracFactory.Interfaces
{
    /// <summary>
    /// Cada producto distinto de una familia de productos debe tener una interfaz base.
    /// Todas las variantes del producto deben implementar esta interfaz.
    /// </summary>
    public interface IButton
    {
        string UsefulButton();
    }
}
