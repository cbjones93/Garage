using System;

namespace Garage
{
    public class Ram : Vehicle, IGas // Gas powered truck
    {
        public double FuelCapacity { get; set; }
  

        public void RefuelTank()
        {
            // method definition omitted
        }
         public int CurrentTankPercentage {get; set;}
          public override void Drive()
          {
              Console.WriteLine($"The {MainColor} Ram growls by you.");
          }
    }
}