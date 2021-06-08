namespace Garage
{
    public interface IElectric
    {
      void ChargeBattery()
        {
            // method definition omitted
        }
        double BatteryKWh { get; set; }
        int CurrentChargePercentage { get; set; }
    }
}