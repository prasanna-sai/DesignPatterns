using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var machine = new GumballMachine(3);
            machine.InsertQuarter();
            machine.TurnCrank();
            machine.InsertQuarter();
            machine.TurnCrank();
            machine.InsertQuarter();
            machine.TurnCrank();
        }
    }
}
