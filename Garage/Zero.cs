using System;


namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; } = 45;

        public void ChargeBattery()
        {
            // method definition omitted
            CurrentChargePercentage = 100;

        }
        public override void Drive()
        {

            Console.WriteLine("Big OOfer");
        }
    }
}