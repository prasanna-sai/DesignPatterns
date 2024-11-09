using System;
namespace StarBuzz
{
    public class Espresso : IBeverage
    {
        public string Description { get; set; }

        public double Cost { get; set; }

        public Espresso()
        {
            Cost = 1.99;
            Description = "Espresso";
        }
    }

    public class HouseBlend  : IBeverage
    {
        public string Description { get; set; }

        public double Cost { get; set; }

        public HouseBlend()
        {
            Cost = 0.89;
            Description = "HouseBlend";
        }
    }


    public class DarkRoast : IBeverage
    {
        public string Description { get; set; }

        public double Cost { get; set; }

        public DarkRoast()
        {
            Cost = 0.99;
            Description = "DarkRoast";
        }
    }

    public class Decaf : IBeverage
    {
        public string Description { get; set; }

        public double Cost { get; set; }

        public Decaf()
        {
            Cost = 1.05;
            Description = "Decaf";
        }
    }

    public class Mocha : ICondimentDecorator
    {
        public string Description { get; set; }

        public double Cost { get; set; }

        public IBeverage Beverage { get; set; }

        public Mocha(IBeverage beverage)
        {
            Cost = beverage.Cost + 0.20;
            Description = beverage.Description +  " Mocha";
        }
    }

    public class Soy : ICondimentDecorator
    {
        public string Description { get; set; }

        public double Cost { get; set; }

        public IBeverage Beverage { get; set; }

        public Soy(IBeverage beverage)
        {
            Cost = beverage.Cost + 0.15;
            Description = beverage.Description + " Soy";
        }
    }

    public class Whip : ICondimentDecorator
    {
        public string Description { get; set; }

        public double Cost { get; set; }

        public IBeverage Beverage { get; set; }

        public Whip(IBeverage beverage)
        {
            Cost = beverage.Cost + 0.10;
            Description = beverage.Description + " Whip";
        }

        public class SteamedMilk : ICondimentDecorator
        {
            public string Description { get; set; }

            public double Cost { get; set; }

            public IBeverage Beverage { get; set; }

            public SteamedMilk(IBeverage beverage)
            {
                Cost = beverage.Cost + 0.20;
                Description = beverage.Description + " SteamedMilk";
            }
        }
    }
}