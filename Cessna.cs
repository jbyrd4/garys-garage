using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage {get; set;} = 0;
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flashes by you like a hurricane. Zzzzoooooommm!");           
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle gently turns {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessa lands softly and stops.");
        }
        public  Cessna(double fuel, string color, int seats)
        {
            FuelCapacity = fuel;
            MainColor = color;
            MaximumOccupancy = seats;
        }
    }
}