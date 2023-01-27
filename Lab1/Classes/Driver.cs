using Lab1.Interfaces;

namespace Lab1.Classes
{
    internal class Driver : IDriver
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int AgeStage { get; set; }
        public ICar Car { get; set; }
        public IRoadmap Roadmap { get; set; }

        public void DriveToPoint(IPoint point)
        {
            Car.DriveToPoint(point);
        }

        public void FuelUpTheCar()
        {
            Car.FuelUp();
        }

        public void LoadTheCar(List<ILoad> loads)
        {
            Car.LoadDown();
        }

        public void StopForSleepover()
        {
            Car.Stop();
        }

        public void TellCurrentLocation()
        {
        }

        public void UnloadTheCar()
        {
            Car.LoadDown();
        }
    }
}
