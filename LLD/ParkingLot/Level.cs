using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Level
    {
        public int floor {  get; private set; }

        public List<ParkingSpot> parkingSpots { get; private set; }

        public Level(int floor, int parkingSpots)
        {
            this.floor = floor;
            this.parkingSpots = new List<ParkingSpot>(parkingSpots);

            double spotsForBikes = 0.50;
            double spotsForCars = 0.40;

            int numBikes = (int)(parkingSpots * spotsForBikes);
            int numCars = (int)(parkingSpots * spotsForCars);

            for (int i = 1; i <= numBikes; i++)
            {
                this.parkingSpots.Add(new ParkingSpot(i, VehicleType.Bike));
            }
            for (int i = numBikes + 1; i <= numBikes + numCars; i++)
            {
                this.parkingSpots.Add(new ParkingSpot(i, VehicleType.Car));
            }
            for (int i = numBikes + numCars + 1; i <= parkingSpots; i++)
            {
                this.parkingSpots.Add(new ParkingSpot(i, VehicleType.Truck));
            }
        }

        public bool ParkVehicle(Vehicle vehicle)
        {
            lock (parkingSpots)
            {
                foreach (var spot in parkingSpots)
                {
                    if (spot.IsAvailable() && spot.vehicleType == vehicle.Type)
                    {
                        spot.ParkVehicle(vehicle);
                        return true;
                    }
                }
            }
            return false;
        }

        public bool UnparkVehicle(Vehicle vehicle)
        {
            lock (parkingSpots)
            {
                foreach (var spot in parkingSpots)
                {
                    if (!spot.IsAvailable() && spot.vehicle.Equals(vehicle))
                    {
                        spot.UnparkVehicle();
                        return true;
                    }
                }
            }
            return false;
        }

        public void DisplayAvailability()
        {
            Console.WriteLine($"Level {floor} Availability:");
            foreach (var spot in parkingSpots)
            {
                Console.WriteLine($"Spot {spot.spotNumber}: {(spot.IsAvailable() ? "Available For" : "Occupied By")} {spot.vehicleType}");
            }
        }
    }
}
