using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                MainColor = "White Lightning"
            };
            Tesla modelS = new Tesla()
            {
                MainColor = "Red Hot"
            };

            Cessna mx410 = new Cessna()
            {
                MainColor = "Brownie Town"
            };
            Ram bigBoy = new Ram()
            {
                MainColor = "Ice Baby Blue"
            };


            Console.WriteLine("--------------");
            fxs.Drive();
            fxs.Turn("Lefty Loose-y");
            fxs.Stop();

            Console.WriteLine("--------------");
            modelS.Drive();
            modelS.Stop();
            modelS.Turn("Righty tighty");

            Console.WriteLine("--------------");
            mx410.Drive();
            mx410.Stop();
            mx410.Turn("downtown");

            Console.WriteLine("--------------");
            bigBoy.Drive();
            bigBoy.Stop();
            bigBoy.Turn("brings it around town");

        }
    }
}
