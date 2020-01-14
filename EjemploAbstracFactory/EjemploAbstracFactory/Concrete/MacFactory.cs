using EjemploAbstracFactory.Interfaces;

namespace EjemploAbstracFactory.Concrete
{
    class MacFactory : IAbstractFactory
    {
        public IButton Button()
        {
            return new MacButton();
        }

        public ICheckbox Checkbox()
        {
            return new MacCheckbox();
        }
    }
}
