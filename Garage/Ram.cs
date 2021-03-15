using System;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; } = 25;
        public void RefuelTank()
        {
            // method definition omitted
            CurrentTankPercentage = 100;
        }
        public override void Drive()
        {

            Console.WriteLine($"The color is {MainColor} and he SCREEEEeeeeEEEaaaaAAAmmMMMMMS!");
        }

        public override void Stop()
        {

            Console.WriteLine($"The Big Boy can't be stopped!");
        }

        public override void Turn(string direction)
        {

            Console.WriteLine($"The Big Boy {direction}");
        }

    }
}