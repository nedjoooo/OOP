using System;
using System.Collections.Generic;
using System.Text;
using _1_Point3D;
using _2.DistanceCalculator;

namespace _3.Paths
{
    public class Path3D
    {
        private List<Point3D> points;
        public readonly double distance;

        public Path3D(List<Point3D> points)
        {
            this.Points = points;
            this.distance = calculateDistance(this.Points);
        }

        public List<Point3D> Points 
        {
            get { return this.points; }
            set { this.points = value; }
        }

        public double Distance
        {
            get { return this.distance; }
        }

        public double calculateDistance(List<Point3D> points)
        {
            double distance = 0;
            for (int i = 0; i < points.Count-1; i++)
			{
                distance += DistanceCalculated.CalcDistance(points[i], points[i + 1]);
			}
            return distance;
        }

        public override string ToString()
        {
            StringBuilder path = new StringBuilder();
            path.AppendLine("Path between points:");
            for (int i = 0; i < this.Points.Count; i++)
            {
                string point = "x: " + this.Points[i].X + ", y: " + this.Points[i].Y + ", z: " + this.Points[i].Z;
                path.AppendLine(point);
            }
            path.AppendLine("is " + this.Distance);
            return path.ToString();
        }
    }
}
