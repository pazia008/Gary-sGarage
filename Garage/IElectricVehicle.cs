using System.Collections.Generic;
using System;


namespace Garage
{
    public interface IElectricVehicle
    {
        int CurrentChargePercentage { get; set; }
        void ChargeBattery();
    }
}