using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The vehicle turned {direction}");
        }

        public virtual void Stop()
        {
            Console.WriteLine("The vehicle SlAmS the breaks!!!!");
        }

    }


}