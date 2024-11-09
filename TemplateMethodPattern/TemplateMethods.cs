using System;
namespace TemplateMethodPattern
{
    public abstract class CaffeineBeverageHelper
    {
        public abstract void PrepareRecipe();
        public abstract void BoilWater();
        public abstract void PourInCup();
    }

    public abstract class CaffeineBeverage : CaffeineBeverageHelper
    {
        public sealed override void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (Hook())
            {
                AddCondiments();
            }
        }

        public abstract void Brew();

        public sealed override void BoilWater()
        {
            Console.WriteLine("Boiling the water");
        }

        public sealed override void PourInCup()
        {
            Console.WriteLine("Pouring in cup");
        }

        public abstract void AddCondiments();

        public virtual bool Hook()
        {
            return true;
        }
    }

    public class Tea : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Brewing the tea");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding condiments related to tea");
        }

        public override bool Hook()
        {
            Console.WriteLine("Enter your preference whether to add condiments");
            var userPreference = Console.ReadLine();
            if(userPreference == "no")
            {
                return false;
            }
            return base.Hook();

        }
    }

    public class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Brewing the coffee");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding condiments related to coffee");
        }

        public override bool Hook()
        {
            Console.WriteLine("Enter your preference whether to add condiments");
            var userPreference = Console.ReadLine();
            if (userPreference == "no")
            {
                return false;
            }
            return base.Hook();

        }
    }
}