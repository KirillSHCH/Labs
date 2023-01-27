namespace Lab1.Interfaces
{
    public interface ICar
    {
        // Properties
        double LoadCapacity {  get; set; }

        string Brand { get; set; }

        int ProductionYear { get; set; }

        double FuelTankCapacity { get; set; }

        double FuelConsumption { get; set; }

        // Methods
        void DriveToPoint(IPoint point);
        void FuelUp();
        void Move();
        void Stop();
        void LoadUp(List<ILoad> loads);
        void LoadDown();
    }
}
