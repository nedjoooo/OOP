using System;
using _1_Point3D;

namespace _2.DistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D point1 = new Point3D(1.2, 2.3, 2);
            Point3D point2 = new Point3D(1.2, 4.4, -2);
            double distance = DistanceCalculated.CalcDistance(point1, point2);
            Console.WriteLine(distance);
        }
    }
}
