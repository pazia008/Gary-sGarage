using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; } = 50;

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

            Console.WriteLine("He is doin his best to stop");
        }

        public override void Turn(string direction)
        {

            Console.WriteLine($"The car goes {direction}");
        }


    }
}