using Lab1.Interfaces;

namespace Lab1.Classes.Cars
{
    abstract public class Car : ICar
    {
        public string Brand { get; set; }
        public double LoadCapacity { get; set; }
        public int ProductionYear { get; set; }
        public double FuelTankCapacity { get; set; }
        public double FuelConsumption { get; set; }
        public string Type { get; protected set; }
        public double CurrentFuelCapacity { get; set; }
        public List<ILoad>? Loads { get; set; }

        public Car(string brand, double loadCapacity, int productionYear, double fuelTankCapacity, double fuelConsumption)
        {
            Brand = brand;
            LoadCapacity = loadCapacity;
            ProductionYear = productionYear;
            FuelTankCapacity = fuelTankCapacity;
            FuelConsumption = fuelConsumption;
            Type = "Абстракт";
            CurrentFuelCapacity = fuelTankCapacity;
        }

        public void DriveToPoint(IPoint point)
        {
            Move();
            Console.WriteLine($"Машина едет в {point.Location}");
        }

        public void FuelUp()
        {
            Stop();
            Console.WriteLine("Машина заправляется");
            CurrentFuelCapacity = FuelTankCapacity;
        }

        public void LoadDown()
        {
            Console.WriteLine("Машина разгружается");
            Loads = null;
        }

        public void LoadUp(List<ILoad> loads)
        {
            Console.WriteLine("Машина загружает груз");
            Loads = loads;
        }

        public void Move()
        {
            Console.WriteLine("Машина начала двигаться");
        }

        public void Stop()
        {
            Console.WriteLine("Машина остановилась");
        }
    }
}
