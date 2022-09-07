
using System;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; } = 75;

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
            Console.WriteLine($"The {MainColor} Ram drives past. RRrrrrrummbbble!");
        }

        public override void Turn()
        {
            Console.WriteLine($"the {MainColor} Ram turns left yo!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram rolls to a stop after rolling a mile down the runway");
        }

    }
}