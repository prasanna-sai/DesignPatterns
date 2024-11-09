using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FactoryPattern
{
    interface IPizzaFactory
    {
        IPizza CreatePizza(string type);

        IPizza OrderPizza(string type);
    }

    public abstract class PizzaFactory
    {
        public abstract PizzaClass CreatePizza(string type);

        public PizzaClass OrderPizza(string type)
        {
            PizzaClass pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }

    public class NYPizzaFactory : IPizzaFactory
    {
        public IPizza CreatePizza(string type)
        {
            if(type == "cheese")
            {
                return new NYCheesePizza();
            }
            return null;
        }

        public IPizza OrderPizza(String type)
        {
            IPizza pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }

    public class NYPizzaFactoryClass : PizzaFactory
    {
        public override PizzaClass CreatePizza(string type)
        {
            if (type == "cheese")
            {
                return new NYCheesePizzaClass();
            }
            return null;
        }
    }

    public class ChicagoPizzaFactory : IPizzaFactory
    {
        public IPizza CreatePizza(string type)
        {
            if (type == "cheese")
            {
                return new ChicagoCheesePizza();
            }
            return null;
        }

        public IPizza OrderPizza(String type)
        {
            IPizza pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }

    public class ChicagoPizzaFactoryClass : PizzaFactory
    {
        public override PizzaClass CreatePizza(string type)
        {
            if (type == "cheese")
            {
                return new ChicagoCheesePizzaClass();
            }
            return null;
        }
    }

    public interface IPizza
    {
        string Name { get; set; }

        string Dough { get; set; }

        string Sauce { get; set; }

        IList<string> Toppings { get; set; }

        void Prepare();

        void Bake();

        void Cut();

        void Box();
    }

    public abstract class PizzaClass
    {
        public string Name { get; set; }

        public string Dough { get; set; }

        public string Sauce { get; set; }

        public IList <string> Toppings { get; set; }

        public PizzaClass()
        {
            Toppings = new List<String>();
        }

        public abstract void Prepare();

        public abstract void Bake();

        public abstract void Cut();

        public void Box()
        {
            Console.WriteLine($"Boxing the {Name}");
        }
    }

    public class NYCheesePizza : IPizza
    {
        public string Name { get; set; }

        public string Dough { get; set; }

        public string Sauce { get; set; }

        public IList<string> Toppings { get; set; }

        public NYCheesePizza()
        {
            Name = "NYCheesePizza";
            Dough = "ThinCrustDough";
            Sauce = "RedTomotoSauce";
            Toppings = new List<String>() { "Onion", "Corn", "Cheese"};
        }

        public void Prepare()
        {
            Console.WriteLine("Something about How NYCheesePizza is prepared");
        }

        public void Cut()
        {
            Console.WriteLine("Something about How NYCheesePizza is cut");
        }

        public void Bake()
        {
            Console.WriteLine("Something about How NYCheesePizza is baked");
        }

        public void Box()
        {
            Console.WriteLine("Something about How NYCheesePizza is Boxed");
        }
    }

    public class NYCheesePizzaClass : PizzaClass
    {
        public NYCheesePizzaClass() : base()
        {
            Name = "NYCheesePizza";
            Dough = "ThinCrustDough";
            Sauce = "RedTomotoSauce";
            Toppings.Union(new List<String>() { "Onion", "Corn", "Cheese" });
        }

        public override void Prepare()
        {
            Console.WriteLine("Something about How NYCheesePizza is prepared");
        }

        public override void Cut()
        {
            Console.WriteLine("Something about How NYCheesePizza is cut");
        }

        public override void Bake()
        {
            Console.WriteLine("Something about How NYCheesePizza is baked");
        }
    }

    public class ChicagoCheesePizza : IPizza
    {
        public string Name { get; set; }

        public string Dough { get; set; }

        public string Sauce { get; set; }

        public IList<string> Toppings { get; set; }

        public ChicagoCheesePizza()
        {
            Name = "ChicagoCheesePizza";
            Dough = "ThickCrustDough";
            Sauce = "MarianoSauce";
            Toppings = new List<String>() { "Mushroom", "Corn", "Cheese" };
        }

        public void Prepare()
        {
            Console.WriteLine("Something about How ChicagoCheesePizza is prepared");
        }

        public void Cut()
        {
            Console.WriteLine("Something about How ChicagoCheesePizza is cut");
        }

        public void Bake()
        {
            Console.WriteLine("Something about How ChicagoCheesePizza is baked");
        }

        public void Box()
        {
            Console.WriteLine("Something about How ChicagoCheesePizza is Boxed");
        }
    }

    public class ChicagoCheesePizzaClass : PizzaClass
    {
        public ChicagoCheesePizzaClass() : base()
        {
            Name = "ChicagoCheesePizza";
            Dough = "ThickCrustDough";
            Sauce = "MarianoSauce";
            Toppings.Union(new List<String>() { "Mushroom", "Corn", "Cheese" });
        }

        public override void Prepare()
        {
            Console.WriteLine("Something about How ChicagoCheesePizza is prepared");
        }

        public override void Cut()
        {
            Console.WriteLine("Something about How ChicagoCheesePizza is cut");
        }

        public override void Bake()
        {
            Console.WriteLine("Something about How ChicagoCheesePizza is baked");
        }
    }
}