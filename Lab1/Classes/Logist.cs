using Lab1.Interfaces;

namespace Lab1.Classes;

public class Logist : ILogist
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<IDriver> drivers { get; set; }

    public Logist(string Name, int Age, List<IDriver> drivers)
    {
        this.Name = Name;
        this.Age = Age;
        this.drivers = drivers;
    }

    public void FillRoadmap(IRoadmap roadmap, List<IPoint> points)
    {
        roadmap.Points = points;
    }

    public void OrderDriverToLoad(IDriver driver, List<ILoad> loads)
    {
        driver.LoadTheCar(driver.Car, loads);
    }

    public void OrderDriverToUnload(IDriver driver)
    {
        driver.UnloadTheCar(driver.Car);
    }

    public void RequestCurrentLocationFromDriver(IDriver driver)
    {
        driver.TellCurrentLocation();
    }

    public void SendDriverToPoint(IDriver driver, IPoint point)
    {
        driver.DriveToPoint(point);
    }

    public void SetFreeDriverOnNewRoadmap(IRoadmap roadmap)
    {
        foreach (var driver in drivers)
        {
            if (driver.roadmap == null)
            {
                driver.roadmap = roadmap;
            }
        }
    }
}
