using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; } = 2;

        public void RefuelTank()
        {
            FuelCapacity = 100;
        }

        public void CurrentTankPercentage()
        {
            Console.WriteLine($"You have %{FuelCapacity} of a tank");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna drives past. CEEEEESSSSSNAAAAAAAA!!!");
        }

    }
}