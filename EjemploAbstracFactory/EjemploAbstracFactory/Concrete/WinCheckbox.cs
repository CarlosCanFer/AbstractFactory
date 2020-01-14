using EjemploAbstracFactory.Interfaces;

namespace EjemploAbstracFactory.Concrete
{
    class WinCheckbox : ICheckbox
    {
        public string AnotherUsefulCheckbox(IButton colaborador)
        {
            var _dresult = colaborador.UsefulButton();
            return $"El resultado de la colaboración de B1 con el ({_dresult})";
        }

        public string UsefulCheckbox()
        {
            return "El resultado es un checkbox windows";
        }
    }
}
