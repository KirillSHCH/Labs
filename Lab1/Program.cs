using Lab1.Classes;
using Lab1.Classes.Cars;
using Lab1.Interfaces;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, эта программа автоматизирует работу логистической компании. Приступим?");
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить");
            Console.ReadKey();

            ILogist logist = CreateLogist();

            Console.WriteLine("Теперь введем данные про водителей:");
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить");
            Console.ReadKey();

            Console.WriteLine("Введите кол-во водителей, которое вы хотите создать");
            int driversNumber = Convert.ToInt32(Console.ReadLine());

            List<IDriver> drivers = CreateDrivers(driversNumber);

            List<IRoadmap> roadmaps = CreateRoadmaps();

            List<ILoad> loads = CreateLoads();

            ChooseDriversForRoadmaps(roadmaps, drivers);
            SendDrivers(logist, drivers, loads);
        }

        private static ILogist CreateLogist()
        {
            Console.WriteLine("Давайте начнем с создания логиста!");

            Console.WriteLine("Введите имя логиста:");
            string logistName = Console.ReadLine() ?? "";

            Console.WriteLine("Введите возраст логиста:");
            int logistAge = Convert.ToInt32(Console.ReadLine());

            return new Logist(logistName, logistAge);
        }

        private static List<IDriver> CreateDrivers(int driversNumber)
        {
            List<IDriver>? drivers = new();

            for (int i = 0; i < driversNumber; i++)
            {
                if (i != 0)
                {
                    Console.WriteLine("Введем данные следующего водителя");
                    Console.WriteLine("Нажмите любую клавишу чтобы продолжить");
                    Console.ReadKey();
                }

                Console.WriteLine("Введите имя водителя");
                string driverName = Console.ReadLine() ?? "";

                Console.WriteLine("Введите возраст водителя");
                int driverAge = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите стаж водителя");
                int driverStage = Convert.ToInt32(Console.ReadLine());

                ICar car = CreateCar();

                IDriver driver = new Driver(driverName, driverAge, driverStage, car);

                drivers.Add(driver);
            }

            return drivers;
        }

        private static ICar CreateCar()
        {
            Console.WriteLine("Введите данные машины водителя");
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить");
            Console.ReadKey();

            Console.WriteLine("Введите марку автомобиля");
            string carBrand = Console.ReadLine() ?? "";

            bool correctCapacityValue = false;
            double carLoadCapacity = 0;

            do
            {
                Console.WriteLine("Введите максимальную грузоподъёмность автомобиля");
                carLoadCapacity = Convert.ToDouble(Console.ReadLine());

                correctCapacityValue = (carLoadCapacity > 0 && carLoadCapacity <= 1000);
                if (!correctCapacityValue)
                {
                    Console.WriteLine("Грузоподъемность должна быть больше 0 и меньше или равно 1000");
                }
            } while (!correctCapacityValue);

            Console.WriteLine("Введите год производства автомобиля");
            int carProductionYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите объем топливного бака");
            double carFuelTankCapacity = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите расход топлива на 100км");
            double carFuelConsuption = Convert.ToDouble(Console.ReadLine());

            if (carLoadCapacity <= 100)
            {
                return new SmallCar(carBrand, carLoadCapacity, carProductionYear, carFuelTankCapacity, carFuelConsuption);
            } else if (carLoadCapacity <= 350)
            {
                return new MediumCar(carBrand, carLoadCapacity, carProductionYear, carFuelTankCapacity, carFuelConsuption);
            } else
            {
                return new BigCar(carBrand, carLoadCapacity, carProductionYear, carFuelTankCapacity, carFuelConsuption);
            }
        }

        private static List<IRoadmap> CreateRoadmaps()
        {
            List<IRoadmap> roadmaps = new();

            Console.WriteLine("Теперь заполним маршрутные листы");
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить");
            Console.ReadKey();

            Console.WriteLine("Введите кол-во маршрутных листов, которые вы хотите создать");
            int roadmapsCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < roadmapsCount; i++)
            {
                if (i != 0)
                {
                    Console.WriteLine("Введем данные следующего маршрутного листа!");
                    Console.WriteLine("Нажмите любую клавишу чтобы продолжить");
                    Console.ReadKey();
                }
                Console.WriteLine("Введите кол-во точек, которые вы хотите создать в данном маршрутном листе");
                int pointsCount = Convert.ToInt32(Console.ReadLine());

                List<IPoint> points = new();

                for (int a = 0; a < pointsCount; a++)
                {
                    if (a != 0)
                    {
                        Console.WriteLine("Введем данные следующей точки!");
                        Console.WriteLine("Нажмите любую клавишу чтобы продолжить");
                        Console.ReadKey();
                    }
                    Console.WriteLine("Введите наименование пункта");
                    string pointName = Console.ReadLine() ?? "";

                    Console.WriteLine("Введите дистанцию до пункта");
                    double pointDistance = Convert.ToDouble(Console.ReadLine());

                    IPoint point = new Point(pointName, pointDistance);

                    points.Add(point);
                }

                IRoadmap roadmap = new Roadmap(points);

                roadmaps.Add(roadmap);
            }

            return roadmaps;
        }

        private static List<ILoad> CreateLoads()
        {
            List<ILoad> loads = new();

            Console.WriteLine("Заполним информацию о грузах");
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить");
            Console.ReadKey();

            Console.WriteLine("Введите кол-во грузов");
            int loadsCount = Convert.ToInt32(Console.ReadLine());

            for (var i =0; i < loadsCount; i++)
            {
                if (i != 0)
                {
                    Console.WriteLine("Введем данные следующего груза!");
                    Console.WriteLine("Нажмите любую клавишу чтобы продолжить");
                    Console.ReadKey();
                }

                Console.WriteLine("Введите вес груза");
                double weight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите наименование груза");
                string name = Console.ReadLine() ?? "";

                ILoad load = new Load(weight, name);

                loads.Add(load);
            }

            return loads;
        }

        private static void ChooseDriversForRoadmaps(List<IRoadmap> roadmaps, List<IDriver> drivers)
        {
            foreach (IRoadmap roadmap in roadmaps)
            {
                List<IDriver> filteredDrivers = new();

                foreach (IDriver driver in drivers)
                {
                    if (driver.Roadmap == null)
                    {
                        filteredDrivers.Add(driver);
                    }
                }

                if (filteredDrivers.Count == 0)
                {
                    Console.WriteLine("Свободные водители кончились");
                    break;
                }

                bool correctDriver = false;
                int driverIndex;

                do
                {
                    string pointsLocations = string.Join(" - ", roadmap?.Points?.Select(elem => elem.Location));

                    Console.WriteLine($"Выберите водителя, который поедет по маршруту '{pointsLocations}'");

                    int i = 0;


                    foreach (IDriver driver in filteredDrivers)
                    {
                        Console.WriteLine($"{i} - {driver.Name}");
                        i++;
                    }

                    driverIndex = Convert.ToInt32(Console.ReadLine());

                    correctDriver = ((driverIndex >= 0) && (driverIndex < filteredDrivers.Count()));

                } while (!correctDriver);

                filteredDrivers[driverIndex].Roadmap = roadmap;
            }
        }

        private static void SendDrivers(ILogist logist, List<IDriver> drivers, List<ILoad> loads)
        {
            Console.WriteLine("Нажмите любую кнопку, чтобы отправить водителей по маршрутам");
            Console.ReadKey();

            foreach (IDriver driver in drivers)
            {
                driver.LoadTheCar(loads);

                foreach (IPoint point in driver.Roadmap?.Points ?? new())
                {
                    logist.SendDriverToPoint(driver, point);
                }
            }
        }
    }
}