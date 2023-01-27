namespace Lab1.Interfaces;

public interface ILogist
{
    // Properties
    string Name { get; set; }

    int Age { get; set; }

    List<IDriver> drivers { get; set; }

    // Methods
    void SendDriverToPoint(IDriver driver, IPoint point);

    void RequestCurrentLocationFromDriver(IDriver driver);

    void OrderDriverToUnload(IDriver driver);

    void SetFreeDriverOnNewRoadmap(IRoadmap roadmap);

    void FillRoadmap(IRoadmap roadmap, List<IPoint> points);

    void OrderDriverToLoad(IDriver driver, List<ILoad> loads);
}
