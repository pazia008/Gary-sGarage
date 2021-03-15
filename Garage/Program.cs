using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
              };
            Console.WriteLine("------------------------");
            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"The Vehivle is {ev.CurrentChargePercentage}% charged");
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"The vehicle is now {ev.CurrentChargePercentage}% charged!");
            }

            /***********************************************/

            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150
              };
            Console.WriteLine("------------------------");
            Console.WriteLine("Gas Vehicles");
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"The tank is {gv.CurrentTankPercentage}% full");
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"The tank is now {gv.CurrentTankPercentage}% full!");
            }


        }
    }
}
