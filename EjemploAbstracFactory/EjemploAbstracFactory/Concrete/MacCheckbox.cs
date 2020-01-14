using EjemploAbstracFactory.Interfaces;

namespace EjemploAbstracFactory.Concrete
{
    class MacCheckbox : ICheckbox
    {
        public string AnotherUsefulCheckbox(IButton colaborador)
        {
            var _dresult = colaborador.UsefulButton();
            return $"El resultado de la colaboración de B2 con el ({_dresult})";
        }

        public string UsefulCheckbox()
        {
            return "El resultado del producto B2";
        }
    }
}
