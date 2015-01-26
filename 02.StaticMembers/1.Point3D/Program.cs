using System;

namespace _1_Point3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D point = new Point3D(1.2, 2.3, 2);
            Console.WriteLine(point.ToString());
            Console.WriteLine(Point3D.StartingPoint);
        }
    }
}
