using StarBuzz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StarBuzz.WhipClass;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBeverage bevarage1 = new Espresso();
            bevarage1 = new Mocha(bevarage1);
            bevarage1 = new Mocha(bevarage1);
            bevarage1 = new Whip(bevarage1);
            Console.WriteLine(bevarage1.Description);
            Console.WriteLine(bevarage1.GetType().GetProperty("Description").GetValue(bevarage1, null));

            Beverage beverage2 = new DarkRoastClass();
            Console.WriteLine(beverage2.Description);
            beverage2 = new SteamedMilkClass(beverage2);
            Console.WriteLine(beverage2.Description);
            beverage2 = new SoyClass(beverage2);
            Console.WriteLine(beverage2.Description);

        }
    }
}
