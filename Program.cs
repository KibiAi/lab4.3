using lab4._3;

class Program
{
    static void Main()
    {
        Road cityRoad = new Road(10, 20, 2);
        Vehicle car = new Vehicle("Автомобіль", 60, 4);
        Vehicle truck = new Vehicle("Вантажівка", 40, 6);
        Vehicle bus = new Vehicle("Автобус", 30, 10);

        Simulation trafficSimulation = new Simulation(cityRoad);
        trafficSimulation.AddVehicle(car);
        trafficSimulation.AddVehicle(truck);
        trafficSimulation.AddVehicle(bus);

        trafficSimulation.SimulateTraffic();

        Console.ReadLine();
    }
}