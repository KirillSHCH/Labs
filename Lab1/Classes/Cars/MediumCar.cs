namespace Lab1.Classes.Cars
{
    public class MediumCar : Car
    {
        public MediumCar(
            string brand,
            double loadCapacity,
            int productionYear,
            double fuelTankCapacity,
            double fuelConsuption
            ) : base(brand, loadCapacity, productionYear, fuelTankCapacity, fuelConsuption)
        {
            Brand = brand;
            LoadCapacity = loadCapacity;
            ProductionYear = productionYear;
            FuelTankCapacity = fuelTankCapacity;
            FuelConsumption = fuelConsuption;
            Type = "Средний";
            CurrentFuelCapacity = fuelTankCapacity;
        }
    }
}
