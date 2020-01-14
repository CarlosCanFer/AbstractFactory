using EjemploAbstracFactory.Interfaces;

namespace EjemploAbstracFactory.Concrete
{
    /// <summary>
    /// Clase Windows factory.
    /// </summary>
    class WinFactory : IAbstractFactory
    {       
        /// <summary>
        /// Las fábricas de concreto producen una familia de productos que pertenecen a una sola
        /// variante. La fábrica garantiza que los productos resultantes son compatibles.
        /// Tenga en cuenta que las firmas de los métodos de Concrete Factory devuelven un resumen
        /// producto, mientras que dentro del método se instancia un producto concreto.
        /// </summary>
        /// <returns></returns>
        public IButton Button()
        {
            return new WinButton();
        }
      
        public ICheckbox Checkbox()
        {
            return new WinCheckbox();
        }
    }
}
