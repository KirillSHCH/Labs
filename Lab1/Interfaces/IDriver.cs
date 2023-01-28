﻿namespace Lab1.Interfaces
{
    public interface IDriver
    {
        // Properties
        string Name { get; set; }

        int Age { get; set; }

        int AgeStage { get; set; }

        ICar Car { get; set; }

        IRoadmap? Roadmap { get; set; }

        int Rest { get; }

        // Methods
        void DriveToPoint(IPoint point);
        void FuelUpTheCar();
        void UnloadTheCar();
        void LoadTheCar(List<ILoad> loads);
        void StopForOvernight();
        void TellCurrentLocation();
    }
}
