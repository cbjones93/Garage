using System;
namespace Garage
{
    public class Tesla: Vehicle, IElectric  // Electric car
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage {get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
          public override void Drive()
          {
              Console.WriteLine($"The {MainColor} Tesla blazes by you.");
          }

          public override void Turn()
          {
              Console.WriteLine($"The {MainColor} Tesla turns right.");
          }

           public override void Stop()
          {
              Console.WriteLine($"The {MainColor} Tesla stops right in front of you.");
          }
    }
}