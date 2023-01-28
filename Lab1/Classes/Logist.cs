using Lab1.Interfaces;

namespace Lab1.Classes;

public class Logist : ILogist
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public List<IDriver>? Drivers { get; set; }

    public Logist(string? name, int age, List<IDriver>? drivers = null)
    {
        Name = name;
        Age = age;
        Drivers = drivers;
    }

    public void FillRoadmap(IRoadmap roadmap, List<IPoint> points)
    {
        roadmap.Points = points;
    }

    public void OrderDriverToLoad(IDriver driver, List<ILoad> loads)
    {
        driver.LoadTheCar(loads);
    }

    public void OrderDriverToUnload(IDriver driver)
    {
        driver.UnloadTheCar();
    }

    public void RequestCurrentLocationFromDriver(IDriver driver)
    {
        driver.TellCurrentLocation();
    }

    public void SendDriverToPoint(IDriver driver, IPoint point)
    {
        Console.WriteLine($"{Name} отправляет {driver.Name} на машрут");
        driver.DriveToPoint(point);
    }

    public void SetFreeDriverOnNewRoadmap(IRoadmap roadmap)
    {
        if (Drivers == null)
        {
            throw new Exception("Почему-то так оказалось, что у этого логиста нет Водителей");
        }

        foreach (IDriver driver in Drivers)
        {
            if (driver.Roadmap == null)
            {
                driver.Roadmap = roadmap;
            }
        }
    }
}
