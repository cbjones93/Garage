using System;
namespace Garage
{
    public class Zero : Vehicle, IElectric  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public int CurrentChargePercentage { get; set; }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by you.");
        }
        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Zero turns right.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero stops abruptly.");
        }
    }
}