using System;
using System.Collections.Generic;
using System.IO;
using _1_Point3D;

namespace _3.Paths
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D(2.2, 4.3, -1);
            Point3D p2 = new Point3D(-2.2, 1.3, -4);
            Point3D p3 = new Point3D(3.2, -1.3, 2.2);
            Point3D p4 = new Point3D(1, -1, 0.2);

            List<Point3D> points1 = new List<Point3D> { p1, p2, p3, p4 };
            List<Point3D> points2 = new List<Point3D> { p1, p2, p3 };
            List<Point3D> points3 = new List<Point3D> { p2, p3, p4 };
            List<Point3D> points4 = new List<Point3D> { p1, p4 };

            Path3D path1 = new Path3D(points1);
            Path3D path2 = new Path3D(points2);
            Path3D path3 = new Path3D(points3);
            Path3D path4 = new Path3D(points4);

            Storage.SavePath("../../paths1.txt", path1);
            Storage.SavePath("../../paths2.txt", path2);
            Storage.SavePath("../../paths3.txt", path3);
            Storage.SavePath("../../paths4.txt", path4);
            Path3D Storagepath1 = Storage.LoadPathsFromFile("../../paths1.txt");
            Console.WriteLine(Storagepath1.ToString());
            Path3D Storagepath2 = Storage.LoadPathsFromFile("../../paths2.txt");
            Console.WriteLine(Storagepath2.ToString());
            Path3D Storagepath3 = Storage.LoadPathsFromFile("../../paths3.txt");
            Console.WriteLine(Storagepath3.ToString());
            Path3D Storagepath4 = Storage.LoadPathsFromFile("../../paths4.txt");
            Console.WriteLine(Storagepath4.ToString());
        }
    }
}
