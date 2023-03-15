using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДР_11_5
{
    /*
     * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Створіть узагальнений клас MyClass, що містить статичний фабричний метод – T FacrotyMethod(), 
     * який породжуватиме екземпляри типу, вказаного як параметр типу (покажчика місця заповнення типом – Т). 
     * Яким має бути тип, що підставляється під T?
    */
    internal class MyClass<T> where T : new()
    {
        public static T FactoryMethod()
        {
            return new T();
        }
    }
}
