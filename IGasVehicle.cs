namespace Garage
{
    public interface IGasVehicle
    {
        double FuelCapacity { get; set; }
        int CurrentTankPercentage {get; set;}
        void RefuelTank();
    }
}