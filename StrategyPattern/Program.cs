using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ducks;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var duck = new MallardDuck();
            duck.flyableBehavior.Fly();
            duck.SetFlyableBehavior(new FlyWithWings());
            duck.flyableBehavior.Fly();
        }
    }
}
