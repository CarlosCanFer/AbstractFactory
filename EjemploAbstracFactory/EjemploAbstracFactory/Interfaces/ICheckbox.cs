namespace EjemploAbstracFactory.Interfaces
{
    /// <summary>
    /// Aquí está la interfaz base de otro producto. Todos los productos pueden interactúan entre sí,
    /// pero la interacción adecuada solo es posible entre productos de la misma variante concreta.
    /// </summary>
    public interface ICheckbox
    {
        // El producto B puede hacer lo suyo ...
        string UsefulCheckbox();

        // ... pero también puede colaborar con el ProductoA.
        //
        // The Abstract Factory se asegura de que todos los productos que crea sean de
        // la misma variante y, por lo tanto, compatible.
        string AnotherUsefulCheckbox(IButton colaborador);
    }
}
