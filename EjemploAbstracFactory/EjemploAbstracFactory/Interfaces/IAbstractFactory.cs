namespace EjemploAbstracFactory.Interfaces
{
    /// <summary>
    /// La interfaz de Abstract Factory declara un conjunto de métodos que devuelven
    /// diferentes productos abstractos. Estos productos se llaman familia y son
    /// relacionado por un tema o concepto de alto nivel. Los productos de una familia son
    /// generalmente pueden colaborar entre ellos. Una familia de productos puede
    /// tienen varias variantes, pero los productos de una variante son incompatibles con productos de otro.
    /// </summary>
    public interface IAbstractFactory
    {
        IButton Button();
        ICheckbox Checkbox();
    }
}
