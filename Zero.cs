using System;

namespace Garage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero drives past. RRrrrrrummbbble!");
        }

        public override void Turn()
        {
            Console.WriteLine($"the {MainColor} Zero turns left yo!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero rolls to a stop after rolling a mile down the runway");
        }

    }
}