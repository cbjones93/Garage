using System;
namespace Garage
{
    public class Cessna : Vehicle, IGas // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }


        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flashes by you like a hurricane. ");
        }

        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Cessna turns right.");
        }
        public int CurrentTankPercentage { get; set; }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna stops a mile down the runway.");
        }
    }
}