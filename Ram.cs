using System;

namespace Garage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram growls by you. Rrrruuummmbbllleee!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Ram rolls around a corner to the {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram aggressively stops.");
        }
        public  Ram(double fuel, string color, int seats)
        {
            FuelCapacity = fuel;
            MainColor = color;
            MaximumOccupancy = seats;
        }
    }
}