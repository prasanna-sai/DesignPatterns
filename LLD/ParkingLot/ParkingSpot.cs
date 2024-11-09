using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ParkingSpot
    {
        public int spotNumber { get; private set; }
        public VehicleType vehicleType { get; private set; }
        public Vehicle vehicle { get; private set; }

        public ParkingSpot(int spotNumber, VehicleType type)
        {
            this.spotNumber = spotNumber;
            vehicleType = type;
        }

        public bool IsAvailable()
        {
            return vehicle == null;
        }

        public void ParkVehicle(Vehicle vehicle)
        {
            if (IsAvailable() && vehicle.Type == vehicleType)
            {
                this.vehicle = vehicle;
            }
            else
            {
                throw new ArgumentException("Invalid vehicle type or spot already occupied.");
            }
        }

        public void UnparkVehicle()
        {
            vehicle = null;
        }

    }
}
