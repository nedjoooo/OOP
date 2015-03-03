using System;

namespace _1.Galactic_GPS
{
    class GalacticGPSTest
    {
        static void Main(string[] args)
        {
            Location home = new Location(18.037986, 28.870097, Planet.Earth);
            Console.WriteLine(home);

        }
    }
}
