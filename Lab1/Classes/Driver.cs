using Lab1.Interfaces;

namespace Lab1.Classes
{
    internal class Driver : IDriver
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int AgeStage { get; set; }
        public ICar Car { get; set; }
        public IRoadmap? Roadmap { get; set; }

        public int Rest { get; } = 300;

        public Driver(string name, int age, int ageStage, ICar car, IRoadmap? roadmap = null)
        {
            Name = name;
            Age = age;
            AgeStage = ageStage;
            Car = car;
            Roadmap = roadmap;
        }

        public void DriveToPoint(IPoint point)
        {
            Car.FuelUp();

            int currentDistance = 0;
            double currentFuel = Car.FuelTankCapacity;

            int restsCount = Convert.ToInt32(point.Distance % Rest);

            if (restsCount > 0)
            {
                for (int i = 0; i < restsCount; i++)
                {
                    if (i != 0)
                    {
                        currentDistance += Rest;
                        currentFuel -= Car.FuelConsumption;
                        StopForOvernight();
                    }

                    Car.DriveToPoint(point);
                    Console.WriteLine($"До точки осталось: {point.Distance - currentDistance}");

                    if (currentFuel <= Car.FuelConsumption)
                    {
                        Car.Stop();
                        FuelUpTheCar();
                        currentFuel = Car.FuelTankCapacity;
                        Console.WriteLine("Водитель заправил машину");
                        Car.Move();
                    }
                }
            } else
            {
                Car.DriveToPoint(point);
            }
        }

        public void FuelUpTheCar()
        {
            Car.FuelUp();
        }

        public void LoadTheCar(List<ILoad> loads)
        {
            Car.Stop();
            Car.LoadUp(loads);
            Car.Move();
        }

        public void StopForOvernight()
        {
            Car.Stop();
            Console.WriteLine("Водитель отдыхает");
            Car.Move();
        }

        public void TellCurrentLocation()
        {
            // TODO: Сделать эту штуку
        }

        public void UnloadTheCar()
        {
            Car.Stop();
            Car.LoadDown();
            Car.Move();
        }
    }
}
