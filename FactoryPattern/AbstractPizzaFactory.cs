using System;
namespace FactoryPattern
{
    public abstract class IngredientsFactory
    {
        public abstract Dough CreateDough();

        public abstract Clam CreateClam();

        public abstract Sauce CreateSauce();
    }

    public class NYIngredientsFactory : IngredientsFactory
    {
        public override Dough CreateDough()
        {
            Console.WriteLine("Adding Thincrust dough");
            return new ThinCrustDough();
        }

        public override Clam CreateClam()
        {
            Console.WriteLine("Adding Fresh clam");
            return new FreshClam();
        }

        public override Sauce CreateSauce()
        {
            Console.WriteLine("Adding Marinara sauce");
            return new Marinara();
        }
    }

    public class ChicagoIngredientsFactory : IngredientsFactory
    {
        public override Dough CreateDough()
        {
            Console.WriteLine("Adding Thickcrust dough");
            return new ThickCrustDough();
        }

        public override Clam CreateClam()
        {
            Console.WriteLine("Adding Frozen clam");
            return new FrozenClam();
        }

        public override Sauce CreateSauce()
        {
            Console.WriteLine("Adding Tomoto sauce");
            return new Tomoto();
        }
    }

    public class Dough
    {
        public string Name { get; set; }
    }

    public class ThinCrustDough : Dough 
    {
        public ThinCrustDough()
        {
            Name = "ThinCrustDough";
        }
    }

    public class ThickCrustDough : Dough
    {
        public ThickCrustDough()
        {
            Name = "ThinCrustDough";
        }
    }

    public class Clam
    {
        public string Name { get; set; }
    }

    public class FreshClam : Clam
    {
        public FreshClam()
        {
            Name = "FreshClam";
        }
    }

    public class FrozenClam : Clam
    {
        public FrozenClam()
        {
            Name = "FrozenClam";
        }
    }

    public class Sauce
    {
        public string Name { get; set; }
    }

    public class Marinara : Sauce
    {
        public Marinara()
        {
            Name = "Marinara Sauce";
        }
    }

    public class Tomoto : Sauce
    {
        public Tomoto()
        {
            Name = "Tomoto Sauce";
        }
    }

    public abstract class AbstractPizza
    {
        public string Name;
        public Dough dough;
        public Clam clam;
        public Sauce sauce;
        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine($"Baking the {Name}");
        }

        public void Cut()
        {
            Console.WriteLine($"Cutting the {Name}");
        }

        public void Box()
        {
            Console.WriteLine($"Boxing the {Name}");
        }
    }

    public class CheesePizza : AbstractPizza
    {
        IngredientsFactory ingredientsFactory;

        public CheesePizza(IngredientsFactory ingredientsFactory)
        {
            this.ingredientsFactory = ingredientsFactory;
        }

        public override void Prepare()
        {
            dough = this.ingredientsFactory.CreateDough();
            clam = this.ingredientsFactory.CreateClam();
            sauce = this.ingredientsFactory.CreateSauce();
        }
    }

    public abstract class AbstractPizzaFactory
    {
        public abstract AbstractPizza CreatePizza(string type);

        public AbstractPizza OrderPizza(string type)
        {
            AbstractPizza pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }

    public class NYAbstractPizzaFactory : AbstractPizzaFactory
    {
        public IngredientsFactory ingredientsFactory = new NYIngredientsFactory();
        public override AbstractPizza CreatePizza(string type)
        {
            if (type == "cheese")
            {
                return new CheesePizza(ingredientsFactory);
            }
            return null;
        }
    }

    public class ChicagoAbstractPizzaFactory : AbstractPizzaFactory
    {
        public IngredientsFactory ingredientsFactory = new ChicagoIngredientsFactory();
        public override AbstractPizza CreatePizza(string type)
        {
            if (type == "cheese")
            {
                return new CheesePizza(ingredientsFactory);
            }
            return null;
        }
    }
}