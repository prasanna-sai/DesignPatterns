using System;
namespace StarBuzz
{

    public class Beverage
    {
        public string Description { get; set; }

        public double Cost { get; set; }
    }

    public class CondimentDecorator : Beverage
    {
        public Beverage Beverage { get; set; }
    }
    public class EspressoClass : Beverage
    {
        public EspressoClass()
        {
            Cost = 1.99;
            Description = "Espresso";
        }
    }

    public class HouseBlendClass  : Beverage
    {
        public HouseBlendClass()
        {
            Cost = 0.89;
            Description = "HouseBlend";
        }
    }


    public class DarkRoastClass : Beverage
    {
        public DarkRoastClass()
        {
            Cost = 0.99;
            Description = "DarkRoast";
        }
    }

    public class DecafClass : Beverage
    {
        public DecafClass()
        {
            Cost = 1.05;
            Description = "Decaf";
        }
    }

    public class MochaClass : CondimentDecorator
    {
        public MochaClass(Beverage beverage)
        {
            Cost = beverage.Cost + 0.20;
            Description = beverage.Description +  " Mocha";
        }
    }

    public class SoyClass : CondimentDecorator
    {
        public SoyClass(Beverage beverage)
        {
            Cost = beverage.Cost + 0.15;
            Description = beverage.Description + " Soy";
        }
    }

    public class WhipClass : CondimentDecorator
    {
        public WhipClass(Beverage beverage)
        {
            Cost = beverage.Cost + 0.10;
            Description = beverage.Description + " Whip";
        }

        public class SteamedMilkClass : CondimentDecorator
        {
            public SteamedMilkClass(Beverage beverage)
            {
                Cost = beverage.Cost + 0.20;
                Description = beverage.Description + " SteamedMilk";
            }
        }
    }
}