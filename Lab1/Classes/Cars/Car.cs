using Lab1.Interfaces;

namespace Lab1.Classes.Cars
{
    abstract public class Car : ICar
    {
        public double LoadCapacity { get; set; }
        public string Brand { get; set; }
        public int ProductionYear { get; set; }
        public double FuelTankCapacity { get; set; }
        public double FuelConsumption { get; set; }

        public void DriveToPoint(IPoint point)
        {
        }

        public void FuelUp()
        {
        }

        public void LoadDown()
        {
        }

        public void LoadUp(List<ILoad> loads)
        {
        }

        public void Move()
        {
        }

        public void Stop()
        {
        }
    }
}
