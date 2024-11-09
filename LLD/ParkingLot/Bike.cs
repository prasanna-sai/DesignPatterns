using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bike : Vehicle
    {
        public Bike(string licensePlateNumber) : base(licensePlateNumber, VehicleType.Bike)
        {

        }
    }
}
