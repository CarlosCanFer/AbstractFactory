using EjemploAbstracFactory.Concrete;
using EjemploAbstracFactory.Interfaces;
using System;

namespace EjemploAbstracFactory.Controller
{
    class Aplicacion
    {
        public void Main()
        {
            Console.WriteLine("Aplicación: Prueba del código del cliente con el primer tipo de fábrica ...");
            AplicacionMethod(new WinFactory());
            Console.WriteLine();

            Console.WriteLine("Aplicación: Probar el mismo código de cliente con el segundo tipo de fábrica ...");
            AplicacionMethod(new MacFactory());
        }

        public void AplicacionMethod(IAbstractFactory factory)
        {
            var Button = factory.Button();
            var Checkbox = factory.Checkbox();

            Console.WriteLine(Checkbox.UsefulCheckbox());
            Console.WriteLine(Checkbox.AnotherUsefulCheckbox(Button));

        }
    }
}
