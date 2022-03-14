using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle  // Electric car
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage {get; set;} = 0;
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla zips by you. Yeeeeoooowwww!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle squeels around a {direction} turn.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla abrubtly stops.");
        }
        public  Tesla(double battery, string color, int seats)
        {
            BatteryKWh = battery;
            MainColor = color;
            MaximumOccupancy = seats;
        }
    }
}