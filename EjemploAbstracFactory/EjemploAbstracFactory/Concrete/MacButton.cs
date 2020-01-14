using EjemploAbstracFactory.Interfaces;

namespace EjemploAbstracFactory.Concrete
{
    class MacButton : IButton
    {
        public string UsefulButton()
        {
            return "El resultado es el boton Mac";
        }
    }
}
