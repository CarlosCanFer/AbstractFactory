using EjemploAbstracFactory.Interfaces;

namespace EjemploAbstracFactory.Concrete
{
    class WinButton : IButton
    {
        public string UsefulButton()
        {
            return "El resultado es el boton windows";
        }
    }
}
