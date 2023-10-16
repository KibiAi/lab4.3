using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._3
{
    class Simulation
    {
        private Road road;
        private List<Vehicle> vehicles;

        public Simulation(Road road)
        {
            this.road = road;
            vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void SimulateTraffic()
        {
            Console.WriteLine($"Дорога довжиною {road.Length} км, шириною {road.Width} м, з {road.NumberOfLanes} смугами.");
            Console.WriteLine("Початок симуляції руху.");

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Move();
                Thread.Sleep(1000);
            }

            Console.WriteLine("Завершення симуляції руху.");
        }
    }
}
