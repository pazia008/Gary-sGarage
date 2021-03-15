using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle   // Electric car
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; } = 55;
        public void ChargeBattery()
        {
            // method definition omitted
            CurrentChargePercentage = 100;
        }
        public override void Drive()
        {

            Console.WriteLine($"The color is {MainColor} and your Tesla hummmmmmmmmmmmmmmmmmmmms to you!");
        }

    }
}