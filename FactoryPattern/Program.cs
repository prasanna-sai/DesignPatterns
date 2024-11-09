using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPizzaFactory NYPizzaFactoryInteface = new NYPizzaFactory();
            NYPizzaFactoryInteface.OrderPizza("cheese");

            PizzaFactory nYPizzaFactoryClass = new NYPizzaFactoryClass();
            nYPizzaFactoryClass.OrderPizza("cheese");

            IPizzaFactory ChicagoPizzaFactoryInteface = new ChicagoPizzaFactory();
            ChicagoPizzaFactoryInteface.OrderPizza("cheese");

            PizzaFactory chicagoPizzaFactoryClass = new ChicagoPizzaFactoryClass();
            chicagoPizzaFactoryClass.OrderPizza("cheese");

            AbstractPizzaFactory chicagoAbstractPizzaFactory = new ChicagoAbstractPizzaFactory();
            AbstractPizzaFactory nYAbstractPizzaFactory = new NYAbstractPizzaFactory();

            var chicagoCheesePizza = chicagoAbstractPizzaFactory.OrderPizza("cheese");
            var nyCheesePizza = nYAbstractPizzaFactory.OrderPizza("cheese");
            chicagoCheesePizza.Name = "Chicago Cheese Pizza";
            nyCheesePizza.Name = "NewYork Cheese Pizza";
        }
    }
}
