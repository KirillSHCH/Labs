namespace Lab1.Classes.Cars
{
    public class BigCar : Car
    {
        public BigCar(
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
            Type = "Большой";
            CurrentFuelCapacity = fuelTankCapacity;
        }
    }
}
