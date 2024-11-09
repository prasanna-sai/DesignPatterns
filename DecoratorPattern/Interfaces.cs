using System;
namespace StarBuzz
{
    public interface IBeverage
    {
        string Description { get; set; }

        double Cost { get; set; }
    }

    public interface ICondimentDecorator : IBeverage
    {
        IBeverage Beverage { get; set; }
    }
}