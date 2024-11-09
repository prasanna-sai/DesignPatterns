using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Vehicle
    {
        public string LicensePlateNumber;
        public VehicleType Type { get; private set; }

        public Vehicle(string licensePlateNumber, VehicleType type)
        {
            LicensePlateNumber = licensePlateNumber;
            Type = type;
        }
    }
}
