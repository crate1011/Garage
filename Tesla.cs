using System;

namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drives past. RRrrrreeeeeeeeee!");
        }

        public override void Turn()
        {
            Console.WriteLine($"the {MainColor} Tesla turns left yo!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla rolls to a stop after rolling a mile down the runway");
        }

    }
}