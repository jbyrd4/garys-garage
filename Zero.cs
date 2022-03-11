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
            Console.WriteLine($"The {MainColor} Zero zips by you. Yeeeooowwww!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle carefully turns {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero gently glides to a stop.");
        }
        public  Zero(double battery, string color, int seats)
        {
            BatteryKWh = battery;
            MainColor = color;
            MaximumOccupancy = seats;
        }
    }
}